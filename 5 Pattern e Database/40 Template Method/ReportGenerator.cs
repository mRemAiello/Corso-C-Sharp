namespace PatternEDatabase.TemplateMethod;

public abstract class ReportGenerator
{
    public void Generate()
    {
        Console.WriteLine($"\nInizio generazione report: {Titolo}\n");

        var data = LoadData();
        var formatted = FormatReport(data);
        ExportReport(formatted);
        AfterExport();
    }

    public abstract string Titolo { get; }

    protected abstract string LoadData();

    protected abstract string FormatReport(string data);

    protected virtual void ExportReport(string formattedReport)
    {
        Console.WriteLine("--- Report esportato ---");
        Console.WriteLine(formattedReport);
        Console.WriteLine("------------------------\n");
    }

    protected virtual void AfterExport()
    {
        Console.WriteLine("Operazioni di chiusura completate.\n");
    }
}
