namespace LinqExamples;

public static class OrderByExample
{
    public static void Execute()
    {
        List<int> valori = new() { 42, 7, 19, 73, 3, 27 };

        IEnumerable<int> valoriOrdinati = valori.OrderBy(v => v);

        Console.WriteLine("OrderBy - Valori ordinati in modo crescente: " + string.Join(", ", valoriOrdinati));
        Console.WriteLine();
    }
}
