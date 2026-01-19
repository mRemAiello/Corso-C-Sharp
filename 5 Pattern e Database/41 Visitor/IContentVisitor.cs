namespace PatternEDatabase.Visitor;

public interface IContentVisitor
{
    void VisitDocument(Document document);
    void VisitParagraph(Paragraph paragraph);
    void VisitImage(Image image);
}
