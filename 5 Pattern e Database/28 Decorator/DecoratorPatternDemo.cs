using System.Globalization;

namespace PatternEDatabase.Decorator;

public static class DecoratorPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("*** Decorator Pattern: Noleggio Auto ***\n");

        ICarRental noleggioBase = new FerrariCarRental();
        StampaDettagli("Offerta base", noleggioBase);

        ICarRental noleggioConGps = new GpsDecorator(noleggioBase);
        StampaDettagli("Aggiunta navigatore", noleggioConGps);

        ICarRental noleggioFamiglia = new AdditionalDriverDecorator(new FullInsuranceDecorator(noleggioConGps));
        StampaDettagli("Pacchetto famiglia", noleggioFamiglia);

        // 39.90 + 4.5 + 6.00 + 15.00 = 65.40
        // Descrizione = Noleggio auto base, Navigatore GPS, Conducente aggiuntivo, Assicurazione completa
        ICarRental baseCarRental = new FerrariCarRental();
        var gpsDecorator = new GpsDecorator(baseCarRental);
        var additionalDriverDecorator = new AdditionalDriverDecorator(gpsDecorator);
        ICarRental noleggioPremium = new FullInsuranceDecorator(additionalDriverDecorator);
        var costo = noleggioPremium.CalcolaCosto();
        StampaDettagli("Pacchetto premium", noleggioPremium);
    }

    private static void StampaDettagli(string titolo, ICarRental noleggio)
    {
        Console.WriteLine(titolo);
        Console.WriteLine($" - Descrizione: {noleggio.Descrizione}");
        Console.WriteLine($" - Costo totale: {noleggio.CalcolaCosto().ToString("C", CultureInfo.GetCultureInfo("it-IT"))}\n");
    }
}
