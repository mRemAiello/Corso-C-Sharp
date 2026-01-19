namespace PatternEDatabase.Visitor;

public sealed class Document : IContentElement
{
    private readonly List<IContentElement> _elements = new();

    public IReadOnlyList<IContentElement> Elements => _elements;

    public void Add(IContentElement element) => _elements.Add(element);

    public void Accept(IContentVisitor visitor)
    {
        visitor.VisitDocument(this);

        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }
}
