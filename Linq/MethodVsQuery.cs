public static class MethodVsQuery
{
    public static void Execute()
    {
        List<int> numeri = new() { 1, 2, 3, 4, 5, 6 };

        // Sintassi con metodi
        var numeriPariMetodo = numeri.Where(n => n % 2 == 0).Select(n => n);

        // Sintassi query
        var numeriPariQuery = from n in numeri
                              where n % 2 == 0
                              select n;

        Console.WriteLine("Sintassi con metodi: " + string.Join(", ", numeriPariMetodo));
        Console.WriteLine("Sintassi query: " + string.Join(", ", numeriPariQuery));
    }
}
