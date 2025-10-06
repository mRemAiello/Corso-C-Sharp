using System;

namespace PatternEDatabase.Facade;

public class StreamingService
{
    public void Connect()
    {
        Console.WriteLine("- Servizio di streaming connesso");
    }

    public void Disconnect()
    {
        Console.WriteLine("- Servizio di streaming disconnesso");
    }

    public void Play(string movie)
    {
        Console.WriteLine($"- Riproduzione di '{movie}' avviata");
    }
}
