public record Prodotto(string Nome, decimal Prezzo);

public static class WhereObjectsExample
{
    public static void Execute()
    {
        List<Prodotto> prodotti = new()
        {
            new("Laptop", 999.99m),
            new("Mouse", 25.50m),
            new("Monitor", 199.90m),
            new("Tastiera", 45.00m)
        };

        IEnumerable<Prodotto> prodottiCostosi = prodotti.Where(p => p.Prezzo >= 100m);

        Console.WriteLine("Where - Prodotti costosi:");
        foreach (Prodotto prodotto in prodottiCostosi)
        {
            Console.WriteLine($"- {prodotto.Nome} ({prodotto.Prezzo:C})");
        }

        Console.WriteLine();
    }
}
