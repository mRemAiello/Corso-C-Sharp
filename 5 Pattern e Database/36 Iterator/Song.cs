namespace PatternEDatabase.Iterator;

public record Song(string Title, string Artist, string Genre, int Year, bool IsFavorite)
{
    public override string ToString() => $"{Title} - {Artist} ({Year}, {Genre})";
}
