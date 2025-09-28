using System;

public static class SingletonDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Singleton Demo ===");

        var manager = DatabaseManager.Instance;
        manager.Connect();
        manager.Load();
        manager.Save();

        Console.WriteLine();
        Console.WriteLine("Recupero nuovamente l'istanza del DatabaseManager...");

        var sameManager = DatabaseManager.Instance;
        sameManager.Connect();
        sameManager.Load();
        sameManager.Save();

        Console.WriteLine();
        Console.WriteLine("La stessa istanza viene riutilizzata in tutte le chiamate.");
    }
}
