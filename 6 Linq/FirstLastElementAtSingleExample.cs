public static class FirstLastElementAtSingleExample
{
    public static void Execute()
    {
        List<string> colori = new() { "Rosso", "Verde", "Blu", "Giallo" };

        string primo = colori.First();
        string ultimo = colori.Last();
        string terzo = colori.ElementAt(2);
        string unicoGiallo = colori.Single(c => c == "Giallo");

        Console.WriteLine($"First: {primo}");
        Console.WriteLine($"Last: {ultimo}");
        Console.WriteLine($"ElementAt(2): {terzo}");
        Console.WriteLine($"Single: {unicoGiallo}");
        Console.WriteLine();
    }
}
