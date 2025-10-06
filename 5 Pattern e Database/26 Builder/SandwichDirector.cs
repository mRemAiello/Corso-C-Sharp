namespace PatternEDatabase.Builder;

/// <summary>
/// Il Director incapsula gli step necessari per creare alcune configurazioni predefinite.
/// In questo modo separiamo la logica di costruzione dall'oggetto finale.
/// </summary>
public class SandwichDirector
{
    private readonly SandwichBuilder _builder;

    public SandwichDirector(SandwichBuilder builder)
    {
        _builder = builder;
    }

    public Sandwich CreateClassicClub()
    {
        return _builder
            .Reset()
            .WithBread("Pane integrale")
            .WithProtein("Tacchino")
            .AddVegetable("Lattuga")
            .AddVegetable("Pomodoro")
            .AddCondiment("Maionese")
            .AddCondiment("Mostarda")
            .Toast()
            .Build();
    }

    public Sandwich CreateVegetarian()
    {
        return _builder
            .Reset()
            .WithBread("Pane ai cereali")
            .WithProtein("Hummus")
            .AddVegetable("Zucchine grigliate")
            .AddVegetable("Peperoni")
            .AddVegetable("Rucola")
            .AddCondiment("Olio extravergine")
            .Build();
    }
}
