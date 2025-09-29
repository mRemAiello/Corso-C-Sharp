using System.Buffers;

namespace MemoryManagement.MemoryManagementModule.Span;

public static class SpanExamples
{
    public static void Run()
    {
        Console.WriteLine("--- Span<T> e amici ---");
        SliceAndMutate();
        ReadOnlyProjection();
        MemoryOwnerPooling();
        ArrayPoolUsage();
        Console.WriteLine();
    }

    private static void SliceAndMutate()
    {
        int[] numbers = Enumerable.Range(1, 10).ToArray();
        Span<int> workingSpan = numbers.AsSpan();

        Span<int> middle = workingSpan.Slice(2, 5);
        middle.Fill(42);

        Console.WriteLine("Span slice mutato: " + string.Join(", ", numbers));
    }

    private static void ReadOnlyProjection()
    {
        string sentence = "Memory management avanzato";
        ReadOnlySpan<char> word = sentence.AsSpan(0, 6);

        Console.WriteLine($"ReadOnlySpan proietta senza allocare: '{word}'");
    }

    private static void MemoryOwnerPooling()
    {
        using IMemoryOwner<byte> owner = MemoryPool<byte>.Shared.Rent(256);
        Memory<byte> buffer = owner.Memory[..128];
        Span<byte> span = buffer.Span;
        for (int i = 0; i < span.Length; i++)
        {
            span[i] = (byte)(i * 2);
        }

        int checksum = 0;
        foreach (byte value in span)
        {
            checksum += value;
        }

        Console.WriteLine($"IMemoryOwner pooling (checksum {checksum})");
        // Il dispose dell'owner restituisce il buffer al pool.
    }

    private static void ArrayPoolUsage()
    {
        ArrayPool<int> pool = ArrayPool<int>.Shared;
        int[] rented = pool.Rent(32);
        try
        {
            Span<int> buffer = rented.AsSpan(0, 32);
            buffer.Clear();
            buffer[0] = 7;
            buffer[1] = 11;
            Console.WriteLine($"ArrayPool buffer riutilizzato: {buffer[0]}, {buffer[1]}, {buffer[2]}, {buffer[3]}");
        }
        finally
        {
            pool.Return(rented, clearArray: true);
            Console.WriteLine("Array restituito al pool e pulito.");
        }
    }
}
