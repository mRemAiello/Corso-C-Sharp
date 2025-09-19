namespace LinqExamples;

public static class GroupByParityExample
{
    public static void Execute()
    {
        List<int> numeri = Enumerable.Range(1, 12).ToList();

        IEnumerable<IGrouping<string, int>> gruppi = numeri.GroupBy(n => n % 2 == 0 ? "Pari" : "Dispari");

        Console.WriteLine("GroupBy - Numeri raggruppati per parità:");
        foreach (IGrouping<string, int> gruppo in gruppi)
        {
            Console.WriteLine($"{gruppo.Key}: {string.Join(", ", gruppo)}");
        }

        Console.WriteLine();
    }
}
