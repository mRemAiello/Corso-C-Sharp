using System;
using PatternEDatabase.Adapter;
using PatternEDatabase.Bridge;
using PatternEDatabase.Builder;
using PatternEDatabase.ChainOfResponsibility;
using PatternEDatabase.Command;
using PatternEDatabase.Decorator;
using PatternEDatabase.Facade;
using PatternEDatabase.Factory;
using PatternEDatabase.Observer;
using PatternEDatabase.State;
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
                Console.WriteLine("Argomento non valido. Opzioni disponibili: mvvc, sqlite, singleton, observer, command, state, builder, factory, facade, decorator, chain, bridge, adapter.");
            }

            return;
        }

        var running = true;
        while (running)
        {
            Console.WriteLine("Pattern e accesso ai dati inclusi:");
            Console.WriteLine(" 1. MVVC");
            Console.WriteLine(" 2. SQLite");
            Console.WriteLine(" 3. Singleton");
            Console.WriteLine(" 4. Observer");
            Console.WriteLine(" 5. Command");
            Console.WriteLine(" 6. State");
            Console.WriteLine(" 7. Builder");
            Console.WriteLine(" 8. Factory Method / Abstract Factory");
            Console.WriteLine(" 9. Facade");
            Console.WriteLine("10. Decorator");
            Console.WriteLine("11. Chain of Responsibility");
            Console.WriteLine("12. Bridge");
            Console.WriteLine("13. Adapter");
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
            case "5":
            case "command":
                CommandPatternDemo.Run();
                return true;
            case "6":
            case "state":
                StatePatternDemo.Run();
                return true;
            case "7":
            case "builder":
                BuilderPatternDemo.Run();
                return true;
            case "factory":
            case "factory method":
            case "abstract factory":
                FactoryPatternDemo.Run();
                return true;
            case "8":
                goto case "factory";
            case "9":
            case "facade":
                FacadePatternDemo.Run();
                return true;
            case "10":
            case "decorator":
                DecoratorPatternDemo.Run();
                return true;
            case "11":
            case "chain":
            case "chain of responsibility":
                ChainOfResponsibilityPatternDemo.Run();
                return true;
            case "12":
            case "bridge":
                BridgePatternDemo.Run();
                return true;
            case "13":
            case "adapter":
                AdapterPatternDemo.Run();
                return true;
            default:
                return false;
        }
    }
}
