using System;

namespace PatternEDatabase.Flyweight;

public static class FlyweightPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Flyweight ===");
        Console.WriteLine("Il pattern Flyweight riduce l'uso di memoria condividendo gli oggetti che hanno uno stato interno uguale.");
        Console.WriteLine("Lo stato variabile viene passato dall'esterno solo quando serve.\n");

        var foresta = new Forest();

        foresta.PlantTree(2, 4, 6, "Pino", "Verde scuro", "Rugosa");
        foresta.PlantTree(3, 8, 5, "Pino", "Verde scuro", "Rugosa");
        foresta.PlantTree(10, 2, 8, "Betulla", "Verde chiaro", "Liscia");
        foresta.PlantTree(5, 12, 7, "Pino", "Verde scuro", "Rugosa");
        foresta.PlantTree(11, 7, 4, "Betulla", "Verde chiaro", "Liscia");

        Console.WriteLine("Alberi piantati:");
        foreach (var descrizione in foresta.DescribeTrees())
        {
            Console.WriteLine(" - " + descrizione);
        }

        Console.WriteLine();
        Console.WriteLine($"La foresta contiene {foresta.CountTrees()} alberi ma solo {foresta.CountTreeTypes()} tipi condivisi.");
        Console.WriteLine("Ogni TreeType rappresenta lo stato intrinseco condiviso, mentre le coordinate e l'altezza sono passate dall'esterno.");
        Console.WriteLine("Questo è il cuore del pattern Flyweight: meno oggetti pesanti, più efficienza.");
    }
}
