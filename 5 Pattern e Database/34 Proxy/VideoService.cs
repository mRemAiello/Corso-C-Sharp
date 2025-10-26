using System;

namespace PatternEDatabase.Proxy;

public class VideoService : IVideoService
{
    public string GetVideo(string titolo)
    {
        Console.WriteLine($"Scaricamento del video \"{titolo}\" dal server...");
        return $"Contenuto video di {titolo}";
    }
}
