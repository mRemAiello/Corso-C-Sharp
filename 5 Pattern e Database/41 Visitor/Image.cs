namespace PatternEDatabase.Visitor;

public sealed class Image : IContentElement
{
    public Image(string description, int width, int height)
    {
        Description = description;
        Width = width;
        Height = height;
    }

    public string Description { get; }
    public int Width { get; }
    public int Height { get; }

    public void Accept(IContentVisitor visitor) => visitor.VisitImage(this);
}
