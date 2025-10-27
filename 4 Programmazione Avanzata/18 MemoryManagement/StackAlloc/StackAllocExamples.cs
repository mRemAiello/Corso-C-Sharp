namespace MemoryManagement.MemoryManagementModule.StackAlloc;

/// <summary>
/// Esempio di ref struct per comporre stringhe temporanee senza allocazioni sul managed heap.
/// Dimostra l'uso di stackalloc, scoped e blocchi unsafe/fixed per il pinning.
/// </summary>
public ref struct StackSpanBuilder
{
    private Span<char> _buffer;
    private int _written;

    public StackSpanBuilder(Span<char> buffer)
    {
        _buffer = buffer;
        _written = 0;
    }

    public void Append(scoped ReadOnlySpan<char> text)
    {
        text.CopyTo(_buffer[_written..]);
        _written += text.Length;
    }

    public void AppendNumber(int value)
    {
        if (!value.TryFormat(_buffer[_written..], out int charsWritten))
        {
            throw new InvalidOperationException("Buffer insufficiente");
        }

        _written += charsWritten;
    }

    public ReadOnlySpan<char> WrittenSpan => _buffer[.._written];

    public override string ToString() => new(WrittenSpan);
}

public static class StackAllocExamples
{
    public static unsafe void Run()
    {
        Console.WriteLine("--- stackalloc e ref struct ---");

        Span<char> stackBuffer = stackalloc char[64];
        var builder = new StackSpanBuilder(stackBuffer);
        builder.Append("Stack");
        builder.Append(" alloc demo ");
        builder.AppendNumber(2024);

        Console.WriteLine("Buffer sullo stack: " + builder.ToString());

        fixed (char* pointer = builder.WrittenSpan)
        {
            // Il blocco fixed esegue il pinning dell'area stack fino al termine del blocco.
            Console.WriteLine($"Puntatore pinning: 0x{((nint)pointer):X}");
        }

        Span<int> numbers = stackalloc int[] { 1, 2, 3, 4 };
        scoped Span<int> window = numbers[1..3];
        window[0] = 42;
        Console.WriteLine($"Span scoped modifica vista locale: {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}");

        Console.WriteLine("Nota: ref struct e stackalloc possono vivere solo sullo stack e non possono attraversare async/iterators.");
        Console.WriteLine();
    }
}
