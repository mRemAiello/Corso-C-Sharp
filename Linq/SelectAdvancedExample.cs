namespace LinqExamples;

public static class SelectAdvancedExample
{
    public static void Execute()
    {
        decimal[] venditeMensili = { 850m, 1200m, 950m, 1600m, 2100m, 1750m };
        decimal media = venditeMensili.Average();

        var mesiConTrend = venditeMensili
            .Select((valore, indice) => new
            {
                Mese = indice + 1,
                Valore = valore,
                CrescitaRispettoMedia = valore - media
            })
            .Where(m => m.Valore >= 1000m)
            .Select(m => new
            {
                m.Mese,
                m.Valore,
                Etichetta = m.CrescitaRispettoMedia >= 0 ? "sopra media" : "sotto media"
            });

        Console.WriteLine("Select avanzato - Vendite rilevanti:");
        foreach (var mese in mesiConTrend)
        {
            Console.WriteLine($" - Mese {mese.Mese}: {mese.Valore:C} ({mese.Etichetta})");
        }

        Console.WriteLine();
    }
}
