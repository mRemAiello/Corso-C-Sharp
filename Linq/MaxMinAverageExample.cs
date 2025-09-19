namespace LinqExamples;

public static class MaxMinAverageExample
{
    public static void Execute()
    {
        List<decimal> prezzi = new() { 9.99m, 14.5m, 7.25m, 22.0m, 18.75m };

        decimal prezzoMassimo = prezzi.Max();
        decimal prezzoMinimo = prezzi.Min();
        decimal prezzoMedio = prezzi.Average();

        Console.WriteLine($"Max - Prezzo più alto: {prezzoMassimo:C}");
        Console.WriteLine($"Min - Prezzo più basso: {prezzoMinimo:C}");
        Console.WriteLine($"Average - Prezzo medio: {prezzoMedio:C}");
        Console.WriteLine();
    }
}
