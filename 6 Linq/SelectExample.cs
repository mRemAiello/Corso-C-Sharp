namespace LinqExamples;

public static class SelectExample
{
    public static void Execute()
    {
        List<int> numeri = Enumerable.Range(1, 10).ToList();

        IEnumerable<int> quadrati = numeri.Select(n => n * n);

        Console.WriteLine("Select - Quadrati dei numeri da 1 a 10: " + string.Join(", ", quadrati));
        Console.WriteLine();
    }
}
