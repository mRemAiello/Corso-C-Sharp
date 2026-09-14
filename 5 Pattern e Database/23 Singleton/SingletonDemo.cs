using System;

public static class SingletonDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Singleton Demo ===");

        var database = DatabaseManager.Instance;
        database.Connect();
        database.Load();
        database.Save();

        Console.WriteLine();
        Console.WriteLine("Recupero nuovamente l'istanza del DatabaseManager...");

        database.Connect();
        database.Load();
        database.Save();

        Console.WriteLine();
        Console.WriteLine("La stessa istanza viene riutilizzata in tutte le chiamate.");
    }
}
