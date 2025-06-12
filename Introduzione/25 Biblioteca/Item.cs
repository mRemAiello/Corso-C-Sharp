public class Book
{
    private string? _isbn;
    private string? _title;
    private int _publicationYear;
    private string? _author;

    public Book(string? isbn, string title, int pubYear, string author)
    {
        _isbn = isbn;
        _title = title;
        _publicationYear = pubYear;
        _author = author;
    }

    public string? GetISBN() => _isbn;
}