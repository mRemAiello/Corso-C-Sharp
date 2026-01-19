namespace PatternEDatabase.Iterator;

public class Song
{
    public string Title { get; }
    public string Artist { get; }
    public string Genre { get; }
    public int Year { get; }
    public bool IsFavorite { get; }

    public Song(string title, string artist, string genre, int year, bool isFavorite)
    {
        Title = title;
        Artist = artist;
        Genre = genre;
        Year = year;
        IsFavorite = isFavorite;
    }

    public override string ToString() => $"{Title} - {Artist} ({Year}, {Genre})";
}