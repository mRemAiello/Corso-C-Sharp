using System.Text;

namespace PatternEDatabase.Visitor;

public sealed class MarkdownExportVisitor : IContentVisitor
{
    private readonly StringBuilder _builder = new();

    public string Markdown => _builder.ToString();

    public void VisitDocument(Document document)
    {
        _builder.Clear();
        _builder.AppendLine("# Documento");
        _builder.AppendLine();
    }

    public void VisitParagraph(Paragraph paragraph)
    {
        _builder.AppendLine(paragraph.Text);
        _builder.AppendLine();
    }

    public void VisitImage(Image image)
    {
        _builder.AppendLine($"![{image.Description}](https://example.com/{image.Description.Replace(' ', '-').ToLowerInvariant()}.png)");
        _builder.AppendLine($"> Dimensioni: {image.Width}x{image.Height}");
        _builder.AppendLine();
    }
}
