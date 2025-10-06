using System.Globalization;

namespace PatternEDatabase.Decorator;

public static class DecoratorPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("*** Decorator Pattern: Noleggio Auto ***\n");

        ICarRental noleggioBase = new BasicCarRental();
        StampaDettagli("Offerta base", noleggioBase);

        ICarRental noleggioConGps = new GpsDecorator(noleggioBase);
        StampaDettagli("Aggiunta navigatore", noleggioConGps);

        ICarRental noleggioFamiglia = new AdditionalDriverDecorator(new FullInsuranceDecorator(noleggioConGps));
        StampaDettagli("Pacchetto famiglia", noleggioFamiglia);

        ICarRental noleggioPremium = new FullInsuranceDecorator(new AdditionalDriverDecorator(new GpsDecorator(new BasicCarRental())));
        StampaDettagli("Pacchetto premium", noleggioPremium);
    }

    private static void StampaDettagli(string titolo, ICarRental noleggio)
    {
        Console.WriteLine(titolo);
        Console.WriteLine($" - Descrizione: {noleggio.Descrizione}");
        Console.WriteLine($" - Costo totale: {noleggio.CalcolaCosto().ToString("C", CultureInfo.GetCultureInfo("it-IT"))}\n");
    }
}
