namespace PatternEDatabase.Visitor;

public interface IContentElement
{
    void Accept(IContentVisitor visitor);
}
