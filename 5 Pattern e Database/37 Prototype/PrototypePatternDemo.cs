using System.Text;

namespace PatternEDatabase.Prototype;

public static class PrototypePatternDemo
{
    public static void Run()
    {
        var baseReport = new ReportTemplate(
            "Report settimanale",
            new List<string>
            {
                "Riepilogo metriche",
                "Task completati",
                "Rischi e mitigazioni"
            });

        var reportPerVendite = baseReport.Clone();
        reportPerVendite.Title = "Report vendite - Area Nord";
        reportPerVendite.Sections.Add("Pipeline commerciale");

        var reportPerSupporto = baseReport.Clone();
        reportPerSupporto.Title = "Report supporto clienti";
        reportPerSupporto.Sections[1] = "Ticket risolti";

        Console.WriteLine("--- Prototype ---");
        Console.WriteLine(baseReport.Describe());
        Console.WriteLine(reportPerVendite.Describe());
        Console.WriteLine(reportPerSupporto.Describe());
    }
}

public sealed class ReportTemplate : IPrototype<ReportTemplate>
{
    public ReportTemplate(string title, List<string> sections)
    {
        Title = title;
        Sections = sections;
    }

    public string Title { get; set; }

    public List<string> Sections { get; }

    public ReportTemplate Clone()
    {
        return new ReportTemplate(Title, new List<string>(Sections));
    }

    public string Describe()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Titolo: {Title}");
        builder.AppendLine("Sezioni:");
        foreach (var section in Sections)
        {
            builder.AppendLine($" - {section}");
        }

        return builder.ToString();
    }
}

public interface IPrototype<out T>
{
    T Clone();
}
