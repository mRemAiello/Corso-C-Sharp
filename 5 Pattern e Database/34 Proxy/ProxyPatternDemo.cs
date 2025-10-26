using System;

namespace PatternEDatabase.Proxy;

public static class ProxyPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("*** Proxy Pattern: Servizio di streaming video ***\n");

        IVideoService servizioReale = new VideoService();
        IVideoService proxy = new CachedVideoServiceProxy(servizioReale);

        RiproduciVideo(proxy, "Gita in montagna");
        RiproduciVideo(proxy, "Gita in montagna");
        RiproduciVideo(proxy, "Corso di cucina");
    }

    private static void RiproduciVideo(IVideoService servizio, string titolo)
    {
        Console.WriteLine($"Richiesta del video: {titolo}");
        var contenuto = servizio.GetVideo(titolo);
        Console.WriteLine($"-> Risultato: {contenuto}\n");
    }
}
