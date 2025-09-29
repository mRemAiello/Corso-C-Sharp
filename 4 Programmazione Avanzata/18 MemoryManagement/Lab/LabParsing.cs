using System.Buffers;
using System.Diagnostics;
using System.Globalization;

namespace MemoryManagement.MemoryManagementModule.Lab;

public static class LabParsing
{
    public static void Run()
    {
        Console.WriteLine("--- Lab: parsing e serializzazione ---");
        string csv = GenerateCsvSample(2_000);

        CsvRecord[] allocatingRecords = Benchmark(
            "Parsing allocante",
            () => ParseAllocating(csv));

        CsvRecord[] spanRecords = Benchmark(
            "Parsing ottimizzato Span",
            () => ParseWithSpan(csv));

        Console.WriteLine($"Record equivalenti: {allocatingRecords.Length == spanRecords.Length}");

        _ = Benchmark(
            "Serializzazione allocante",
            () => SerializeAllocating(spanRecords));

        _ = Benchmark(
            "Serializzazione con buffer riutilizzabili",
            () => SerializeWithBuffers(spanRecords));

        Console.WriteLine();
    }

    private static CsvRecord[] ParseAllocating(string csv)
    {
        string[] lines = csv.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        List<CsvRecord> records = new();
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(',');
            records.Add(new CsvRecord(
                int.Parse(parts[0], CultureInfo.InvariantCulture),
                parts[1],
                double.Parse(parts[2], CultureInfo.InvariantCulture)));
        }

        return records.ToArray();
    }

    private static CsvRecord[] ParseWithSpan(string csv)
    {
        ReadOnlySpan<char> span = csv.AsSpan();
        int headerEnd = span.IndexOf('\n');
        if (headerEnd < 0)
        {
            return Array.Empty<CsvRecord>();
        }

        span = span[(headerEnd + 1)..];
        List<CsvRecord> records = new();
        while (!span.IsEmpty)
        {
            int lineEnd = span.IndexOf('\n');
            ReadOnlySpan<char> line = lineEnd >= 0 ? span[..lineEnd] : span;
            if (!line.IsEmpty)
            {
                int firstComma = line.IndexOf(',');
                int secondComma = line[(firstComma + 1)..].IndexOf(',') + firstComma + 1;

                ReadOnlySpan<char> idSpan = line[..firstComma];
                ReadOnlySpan<char> nameSpan = line[(firstComma + 1)..secondComma];
                ReadOnlySpan<char> scoreSpan = line[(secondComma + 1)..];

                int id = int.Parse(idSpan, CultureInfo.InvariantCulture);
                string name = new(nameSpan);
                double score = double.Parse(scoreSpan, CultureInfo.InvariantCulture);

                records.Add(new CsvRecord(id, name, score));
            }

            if (lineEnd < 0)
            {
                break;
            }

            span = span[(lineEnd + 1)..];
        }

        return records.ToArray();
    }

    private static string SerializeAllocating(IEnumerable<CsvRecord> records)
    {
        IEnumerable<string> lines = records.Select(record =>
            string.Join(',', new[]
            {
                record.Id.ToString(CultureInfo.InvariantCulture),
                record.Name,
                record.Score.ToString(CultureInfo.InvariantCulture)
            }));

        return "Id,Name,Score\n" + string.Join('\n', lines);
    }

    private static string SerializeWithBuffers(ReadOnlySpan<CsvRecord> records)
    {
        ArrayPool<char> pool = ArrayPool<char>.Shared;
        char[] buffer = pool.Rent(Math.Max(128, records.Length * 32));
        try
        {
            Span<char> destination = buffer;
            int written = 0;
            written += WriteLine(destination[written..], "Id,Name,Score");
            destination[written++] = '\n';

            foreach (ref readonly CsvRecord record in records)
            {
                written += WriteInt(destination[written..], record.Id);
                destination[written++] = ',';

                ReadOnlySpan<char> nameSpan = record.Name.AsSpan();
                nameSpan.CopyTo(destination[written..]);
                written += nameSpan.Length;

                destination[written++] = ',';
                if (!record.Score.TryFormat(destination[written..], out int charsWritten, provider: CultureInfo.InvariantCulture))
                {
                    throw new InvalidOperationException("Buffer insufficiente per lo score");
                }

                written += charsWritten;
                destination[written++] = '\n';
            }

            return new string(buffer, 0, written);
        }
        finally
        {
            pool.Return(buffer, clearArray: true);
        }
    }

    private static int WriteLine(Span<char> destination, ReadOnlySpan<char> text)
    {
        text.CopyTo(destination);
        return text.Length;
    }

    private static int WriteInt(Span<char> destination, int value)
    {
        if (!value.TryFormat(destination, out int written, provider: CultureInfo.InvariantCulture))
        {
            throw new InvalidOperationException("Buffer insufficiente per l'intero");
        }

        return written;
    }

    private static T Benchmark<T>(string name, Func<T> action)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();
        var sw = Stopwatch.StartNew();
        T result = action();
        sw.Stop();
        long allocated = GC.GetAllocatedBytesForCurrentThread() - before;

        Console.WriteLine($"{name}: {sw.ElapsedMilliseconds,4} ms | {allocated,8} B allocati");
        return result;
    }

    private static string GenerateCsvSample(int rows)
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("Id,Name,Score");
        for (int i = 0; i < rows; i++)
        {
            sb.Append(i.ToString(CultureInfo.InvariantCulture)).Append(',');
            sb.Append("Name").Append(i.ToString(CultureInfo.InvariantCulture)).Append(',');
            sb.AppendLine((Math.Sin(i) * 100).ToString("F2", CultureInfo.InvariantCulture));
        }

        return sb.ToString();
    }

    private readonly record struct CsvRecord(int Id, string Name, double Score);
}
