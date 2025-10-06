namespace PatternEDatabase.Builder;

/// <summary>
/// Rappresenta il prodotto che vogliamo creare con il pattern Builder.
/// La classe è immutabile per rendere evidente la separazione tra costruzione e rappresentazione.
/// </summary>
public sealed class Sandwich
{
    public Sandwich(string bread, string protein, IReadOnlyCollection<string> vegetables, IReadOnlyCollection<string> condiments, bool toasted)
    {
        Bread = bread;
        Protein = protein;
        Vegetables = vegetables;
        Condiments = condiments;
        Toasted = toasted;
    }

    public string Bread { get; }

    public string Protein { get; }

    public IReadOnlyCollection<string> Vegetables { get; }

    public IReadOnlyCollection<string> Condiments { get; }

    public bool Toasted { get; }

    public override string ToString()
    {
        var vegetables = Vegetables.Count > 0 ? string.Join(", ", Vegetables) : "nessuna";
        var condiments = Condiments.Count > 0 ? string.Join(", ", Condiments) : "nessuno";
        var toasted = Toasted ? "sì" : "no";

        return $"Pane: {Bread}\n" +
               $"Proteina: {Protein}\n" +
               $"Verdure: {vegetables}\n" +
               $"Salse: {condiments}\n" +
               $"Tostato: {toasted}";
    }
}
