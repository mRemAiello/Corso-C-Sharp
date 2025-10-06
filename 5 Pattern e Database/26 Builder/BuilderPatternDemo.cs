using System.Text;

namespace PatternEDatabase.Builder;

/// <summary>
/// Classe di supporto per mostrare il funzionamento del pattern Builder.
/// </summary>
public static class BuilderPatternDemo
{
    public static void Run()
    {
        var builder = new SandwichBuilder();
        var director = new SandwichDirector(builder);

        var classic = director.CreateClassicClub();
        var vegetarian = director.CreateVegetarian();

        var custom = builder
            .Reset()
            .WithBread("Baguette")
            .WithProtein("Salmone affumicato")
            .AddVegetable("Cetrioli")
            .AddVegetable("Finocchietto")
            .AddCondiment("Formaggio spalmabile")
            .Toast()
            .Build();

        var output = new StringBuilder();
        output.AppendLine("Esempio di Builder Pattern - Panini Artigianali");
        output.AppendLine(new string('-', 45));
        output.AppendLine("Club sandwich classico:");
        output.AppendLine(classic.ToString());
        output.AppendLine();
        output.AppendLine("Panino vegetariano:");
        output.AppendLine(vegetarian.ToString());
        output.AppendLine();
        output.AppendLine("Creazione personalizzata con la stessa istanza di builder:");
        output.AppendLine(custom.ToString());

        Console.WriteLine(output.ToString());
    }
}
