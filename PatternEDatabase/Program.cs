using PatternEDatabase.Observer;

namespace PatternEDatabaseApp;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pattern e accesso ai dati inclusi:");
        Console.WriteLine(" - 21 MVVC");
        Console.WriteLine(" - 22 SQLite");
        Console.WriteLine(" - 23 Singleton");
        Console.WriteLine(" - 24 Observer");
        Console.WriteLine();
        Console.WriteLine("Verifica ogni cartella per esempi completi e note teoriche.");
        Console.WriteLine();

        ObserverPatternDemo.Run();
    }
}
