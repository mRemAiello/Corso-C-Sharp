using System;
using System.Collections.Generic;

namespace PatternEDatabase.Proxy;

public class CachedVideoServiceProxy : IVideoService
{
    private readonly IVideoService _videoService;
    private readonly Dictionary<string, string> _cache = new(StringComparer.OrdinalIgnoreCase);

    public CachedVideoServiceProxy(IVideoService videoService)
    {
        _videoService = videoService;
    }

    public string GetVideo(string titolo)
    {
        if (_cache.TryGetValue(titolo, out var contenuto))
        {
            Console.WriteLine($"Proxy: video \"{titolo}\" trovato in cache.");
            return contenuto;
        }

        Console.WriteLine($"Proxy: video \"{titolo}\" non in cache, delego al servizio reale.");
        contenuto = _videoService.GetVideo(titolo);
        _cache[titolo] = contenuto;
        return contenuto;
    }
}
