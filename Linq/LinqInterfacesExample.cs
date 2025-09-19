public static class LinqInterfacesExample
{
    public static void Execute()
    {
        List<int> numeri = new() { 2, 4, 6, 8, 10, 12 };

        IEnumerable<int> numeriEnumerabili = numeri.Where(n => n > 6);
        IQueryable<int> numeriInterrogabili = numeri.AsQueryable().Where(n => n < 10);

        StampaRisultati("IEnumerable", numeriEnumerabili);
        StampaRisultati("IQueryable", numeriInterrogabili);

        Console.WriteLine();
    }

    private static void StampaRisultati(string tipoInterfaccia, IEnumerable<int> numeri)
    {
        Console.WriteLine($"{tipoInterfaccia}: {string.Join(", ", numeri)}");
    }
}
