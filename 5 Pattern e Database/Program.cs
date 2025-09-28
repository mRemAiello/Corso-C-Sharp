using System;
using PatternEDatabase.Observer;
using SQLiteExamples;

namespace PatternEDatabaseApp;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            if (!TryRunDemo(args[0]))
            {
                Console.WriteLine("Argomento non valido. Opzioni disponibili: mvvc, sqlite, singleton, observer.");
            }

            return;
        }

        var running = true;
        while (running)
        {
            Console.WriteLine("Pattern e accesso ai dati inclusi:");
            Console.WriteLine(" 1. 21 MVVC");
            Console.WriteLine(" 2. 22 SQLite");
            Console.WriteLine(" 3. 23 Singleton");
            Console.WriteLine(" 4. 24 Observer");
            Console.WriteLine(" Q. Esci");
            Console.WriteLine();
            Console.Write("Seleziona un'opzione: ");

            var choice = Console.ReadLine();
            if (choice == null || choice.Trim().Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                running = false;
                continue;
            }

            if (!TryRunDemo(choice))
            {
                Console.WriteLine("Opzione non valida, riprova.\n");
            }
            else
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("Chiusura del programma. A presto!");
    }

    private static bool TryRunDemo(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        switch (input.Trim().ToLowerInvariant())
        {
            case "1":
            case "mvvc":
                MvvcDemo.Run();
                return true;
            case "2":
            case "sqlite":
                SQLiteDemo.Run();
                return true;
            case "3":
            case "singleton":
                SingletonDemo.Run();
                return true;
            case "4":
            case "observer":
                ObserverPatternDemo.Run();
                return true;
            default:
                return false;
        }
    }
}
