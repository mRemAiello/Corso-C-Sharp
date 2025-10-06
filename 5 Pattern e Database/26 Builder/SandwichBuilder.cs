namespace PatternEDatabase.Builder;

/// <summary>
/// Builder concreto responsabile della costruzione graduale di un <see cref="Sandwich"/>.
/// I metodi restituiscono l'istanza stessa per supportare una sintassi fluente.
/// </summary>
public class SandwichBuilder
{
    private string _bread = "Pane bianco";
    private string _protein = "Tacchino";
    private readonly List<string> _vegetables = new();
    private readonly List<string> _condiments = new();
    private bool _toasted;

    public SandwichBuilder Reset()
    {
        _bread = "Pane bianco";
        _protein = "Tacchino";
        _vegetables.Clear();
        _condiments.Clear();
        _toasted = false;
        return this;
    }

    public SandwichBuilder WithBread(string bread)
    {
        _bread = bread;
        return this;
    }

    public SandwichBuilder WithProtein(string protein)
    {
        _protein = protein;
        return this;
    }

    public SandwichBuilder AddVegetable(string vegetable)
    {
        if (!string.IsNullOrWhiteSpace(vegetable))
        {
            _vegetables.Add(vegetable);
        }

        return this;
    }

    public SandwichBuilder AddCondiment(string condiment)
    {
        if (!string.IsNullOrWhiteSpace(condiment))
        {
            _condiments.Add(condiment);
        }

        return this;
    }

    public SandwichBuilder Toast()
    {
        _toasted = true;
        return this;
    }

    public Sandwich Build()
    {
        return new Sandwich(_bread, _protein, _vegetables.ToArray(), _condiments.ToArray(), _toasted);
    }
}
