namespace PatternEDatabase.Visitor;

public sealed class WordCountVisitor : IContentVisitor
{
    private int _paragraphs;
    private int _images;
    private int _words;

    public int Paragraphs => _paragraphs;
    public int Images => _images;
    public int Words => _words;

    public void VisitDocument(Document document)
    {
        _paragraphs = 0;
        _images = 0;
        _words = 0;
    }

    public void VisitParagraph(Paragraph paragraph)
    {
        _paragraphs++;
        var words = paragraph.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        _words += words.Length;
    }

    public void VisitImage(Image image)
    {
        _images++;
    }
}
