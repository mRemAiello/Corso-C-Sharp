namespace PatternEDatabase.TemplateMethod;

public sealed class SalesReportGenerator : ReportGenerator
{
    public override string Titolo => "Report vendite";

    protected override string LoadData()
    {
        return string.Join(";", new[]
        {
            "Prodotto A|120|12.50",
            "Prodotto B|75|9.99",
            "Prodotto C|40|24.00"
        });
    }

    protected override string FormatReport(string data)
    {
        var righe = data.Split(';', StringSplitOptions.RemoveEmptyEntries);
        var output = new List<string> { "Prodotto | Quantità | Prezzo" };

        foreach (var riga in righe)
        {
            var parti = riga.Split('|', StringSplitOptions.RemoveEmptyEntries);
            output.Add($"{parti[0],-9} | {parti[1],8} | € {parti[2],6}");
        }

        return string.Join(Environment.NewLine, output);
    }
}
