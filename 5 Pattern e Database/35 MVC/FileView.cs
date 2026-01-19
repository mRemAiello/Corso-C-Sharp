using PatternEDatabase.Mvp;

public class FileViewMVC : ICounterView
{
    public string? ReadCommand()
    {
        return File.ReadAllText("command.txt").Trim();
    }

    public void ShowGoodbye()
    {
        Console.WriteLine("\nChiusura della demo MVP.");
    }

    public void ShowUnknownCommand(string command)
    {
        Console.WriteLine($"Comando '{command}' non riconosciuto all'interno del file. Riprova.");
    }

    public void ShowValue(int value)
    {
        Console.WriteLine($"Il valore corrente è: {value}");
    }

    public void ShowWelcome()
    {
        Console.WriteLine("Benvenuto nella demo MVP.");
    }
}