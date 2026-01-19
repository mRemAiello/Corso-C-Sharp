using System;
using System.Collections;

namespace PatternEDatabase.Iterator;

public static class IteratorPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("Esempio Iterator: attraversiamo una playlist con un iteratore personalizzato.\n");

        var playlist = new SongCollection
        {
            new Song("City Lights", "Aurora Lane", "Rock", 2020, false),
            new Song("Morning Breeze", "The Dunes", "Rock", 2018, true),
            new Song("Ocean Echoes", "Blue Horizon", "Pop", 2021, false),
            new Song("Fireflies", "Nocturna", "Pop", 2019, true)
        };

        Console.WriteLine("Scorro tutti i brani con foreach (usa l'iteratore personalizzato):");
        foreach (var song in playlist)
        {
            Console.WriteLine($"- {song}");
        }

        Console.WriteLine("\nScorro solo i brani di genere 'Pop' con un secondo iteratore (IEnumerable):");
        foreach (var song in playlist.ByGenre("Pop"))
        {
            Console.WriteLine($"♪ {song}");
        }

        Console.WriteLine("\nScorro solo i brani dell'artista 'The Dunes' con un secondo iteratore (IEnumerable):");
        foreach (var song in playlist.ByArtist("The Dunes"))
        {
            Console.WriteLine($"♫ {song}");
        }

        Console.WriteLine("\nScorro solo i preferiti con un secondo iteratore (IEnumerable):");
        foreach (var song in playlist.Favorites())
        {
            Console.WriteLine($"★ {song}");
        }

        Console.WriteLine("\nGrazie all'Iterator possiamo nascondere i dettagli della struttura interna e creare più percorsi di scorrimento.");
    }
}