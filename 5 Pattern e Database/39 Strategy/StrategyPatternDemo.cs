using System.Globalization;

namespace PatternEDatabase.Strategy;

public static class StrategyPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("*** Strategy Pattern: calcolo spedizione ***\n");

        var ordine = new Ordine(pesoKg: 4.2m, distanzaKm: 120, valoreMerce: 350m);
        var spedizione = new Spedizione(ordine, new StandardShippingStrategy());

        StampaDettagli(spedizione);

        spedizione.CambiaStrategia(new ExpressShippingStrategy());
        StampaDettagli(spedizione);

        spedizione.CambiaStrategia(new PickupShippingStrategy());
        StampaDettagli(spedizione);

        Console.WriteLine("\nIl contesto cambia strategia senza modificare la logica interna.");
    }

    private static void StampaDettagli(Spedizione spedizione)
    {
        var costo = spedizione.CalcolaCosto();
        Console.WriteLine($"Strategia: {spedizione.Strategia.Nome}");
        Console.WriteLine($"Costo spedizione: {costo.ToString("C", CultureInfo.GetCultureInfo("it-IT"))}\n");
    }
}
