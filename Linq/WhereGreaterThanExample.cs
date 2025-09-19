public static class WhereGreaterThanExample
{
    public static void Execute()
    {
        int[] numeri = { 3, 7, 10, 15, 20, 25 };

        IEnumerable<int> maggioriDiDieci = numeri.Where(n => n > 10);

        Console.WriteLine("Where - Maggiori di 10: " + string.Join(", ", maggioriDiDieci));
        Console.WriteLine();
    }
}
