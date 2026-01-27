namespace PatternEDatabase.TemplateMethod;

public static class TemplateMethodPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("*** Template Method Pattern: generazione report ***");

        var generators = new ReportGenerator[]
        {
            new SalesReportGenerator(),
            new InventoryReportGenerator()
        };

        foreach (var generator in generators)
        {
            generator.Generate();
        }

        Console.WriteLine("Il template method definisce lo scheletro dell'algoritmo, lasciando alle sottoclassi i dettagli.");
    }
}