namespace LinqExamples;

public static class CustomComparerOrderByExample
{
    private sealed class StringLengthComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x is null)
            {
                return -1;
            }

            if (y is null)
            {
                return 1;
            }

            int lengthComparison = x.Length.CompareTo(y.Length);

            return lengthComparison != 0 ? lengthComparison : string.Compare(x, y, StringComparison.Ordinal);
        }
    }

    public static void Execute()
    {
        List<string> parole = new() { "albero", "sole", "computer", "casa", "programmazione", "penna" };

        IEnumerable<string> paroleOrdinataPerLunghezza = parole.OrderBy(p => p, new StringLengthComparer());

        Console.WriteLine("OrderBy con comparatore custom - Parole ordinate per lunghezza: " + string.Join(", ", paroleOrdinataPerLunghezza));
        Console.WriteLine();
    }
}
