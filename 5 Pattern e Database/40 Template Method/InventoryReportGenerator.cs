namespace PatternEDatabase.TemplateMethod;

public sealed class InventoryReportGenerator : ReportGenerator
{
    public override string Titolo => "Report inventario";

    protected override string LoadData()
    {
        return string.Join(";", new[]
        {
            "Magazzino Nord|145",
            "Magazzino Centro|93",
            "Magazzino Sud|210"
        });
    }

    protected override string FormatReport(string data)
    {
        var righe = data.Split(';', StringSplitOptions.RemoveEmptyEntries);
        var output = new List<string> { "Deposito | Scorte" };

        foreach (var riga in righe)
        {
            var parti = riga.Split('|', StringSplitOptions.RemoveEmptyEntries);
            output.Add($"{parti[0],-17} | {parti[1],6} pz");
        }

        return string.Join(Environment.NewLine, output);
    }

    protected override void AfterExport()
    {
        Console.WriteLine("Invio notifica al reparto logistica.\n");
    }
}
