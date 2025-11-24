namespace PatternEDatabase.Facade;

public static class FacadePatternDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Pattern Facade ===");
        Console.WriteLine("Il Facade nasconde la complessità di un sottosistema dietro un'unica interfaccia semplice.\n");

        Projector projector = new();
        var facade = new HomeTheaterFacade(projector);

        facade.StartMovieNight("Ritorno al Futuro");
        Console.WriteLine("Premi invio quando il film è terminato...");
        Console.ReadLine();
        facade.EndMovieNight();
    }
}
