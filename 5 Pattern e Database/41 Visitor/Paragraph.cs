namespace PatternEDatabase.Visitor;

public sealed class Paragraph : IContentElement
{
    public Paragraph(string text)
    {
        Text = text;
    }

    public string Text { get; }

    public void Accept(IContentVisitor visitor) => visitor.VisitParagraph(this);
}
