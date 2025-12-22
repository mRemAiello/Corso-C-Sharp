using System;

namespace PatternEDatabase.Iterator;

public static class IteratorPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("Esempio Iterator: attraversiamo una playlist con un iteratore personalizzato.\n");

        var playlist = new SongCollection();
        playlist.Add(new Song("City Lights", "Aurora Lane", "Synthwave", 2020, false));
        playlist.Add(new Song("Morning Breeze", "The Dunes", "Indie", 2018, true));
        playlist.Add(new Song("Ocean Echoes", "Blue Horizon", "Ambient", 2021, false));
        playlist.Add(new Song("Fireflies", "Nocturna", "Pop", 2019, true));

        Console.WriteLine("Scorro tutti i brani con foreach (usa l'iteratore personalizzato):");
        foreach (var song in playlist)
        {
            Console.WriteLine($"- {song}");
        }

        Console.WriteLine("\nScorro solo i preferiti con un secondo iteratore (IEnumerable):");
        foreach (var song in playlist.Favorites())
        {
            Console.WriteLine($"★ {song}");
        }

        Console.WriteLine("\nGrazie all'Iterator possiamo nascondere i dettagli della struttura interna e creare più percorsi di scorrimento.");
    }
}
