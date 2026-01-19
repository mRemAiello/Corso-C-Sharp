namespace PatternEDatabase.Visitor;

public static class VisitorPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("*** Visitor Pattern: contenuti documento ***\n");

        var document = new Document();
        document.Add(new Paragraph("Il visitor separa le operazioni dalla struttura dei dati."));
        document.Add(new Image("Schema UML", 800, 600));
        document.Add(new Paragraph("Nuovi comportamenti si aggiungono senza modificare gli elementi."));

        var counter = new WordCountVisitor();
        document.Accept(counter);
        Console.WriteLine($"Paragrafi: {counter.Paragraphs}");
        Console.WriteLine($"Immagini: {counter.Images}");
        Console.WriteLine($"Parole: {counter.Words}\n");

        var markdown = new MarkdownExportVisitor();
        document.Accept(markdown);
        Console.WriteLine("Esportazione markdown:\n");
        Console.WriteLine(markdown.Markdown);
    }
}
