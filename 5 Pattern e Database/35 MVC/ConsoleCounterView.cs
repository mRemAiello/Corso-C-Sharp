using System;

namespace PatternEDatabase.Mvp;

/// <summary>
/// Implementazione console della vista per il pattern MVP.
/// </summary>
public class ConsoleCounterView : ICounterView
{
    public void ShowWelcome()
    {
        Console.WriteLine("=== MVP Demo ===");
        Console.WriteLine("Questo esempio mostra come Controller e View collaborino sul Model.\n");
        Console.WriteLine("Comandi disponibili: ");
        Console.WriteLine("  [i]ncrementa  |  [d]ecrementa  |  [r]eset  |  [q]uit");
    }

    public void ShowValue(int value)
    {
        Console.WriteLine($"Valore corrente del contatore: {value}");
    }

    public void ShowUnknownCommand(string command)
    {
        Console.WriteLine($"Comando '{command}' non riconosciuto. Riprova.");
    }

    public string? ReadCommand()
    {
        Console.Write("Seleziona un comando: ");
        return Console.ReadLine();
    }

    public void ShowGoodbye()
    {
        Console.WriteLine("\nChiusura della demo MVP.");
    }
}
