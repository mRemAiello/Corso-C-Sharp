namespace PatternEDatabase.Flyweight;

/// <summary>
/// Rappresenta i dati condivisi tra molti alberi della stessa specie.
/// Queste informazioni sono pesanti da memorizzare, quindi vengono riutilizzate.
/// </summary>
public class TreeType
{
    public TreeType(string specie, string coloreFoglie, string textureCorteccia)
    {
        Specie = specie;
        ColoreFoglie = coloreFoglie;
        TextureCorteccia = textureCorteccia;
    }

    public string Specie { get; }
    public string ColoreFoglie { get; }
    public string TextureCorteccia { get; }

    public string Describe(int posizioneX, int posizioneY, int altezzaMetri)
    {
        return $"Albero di tipo {Specie} alto {altezzaMetri} m in ({posizioneX}, {posizioneY}) - foglie {ColoreFoglie}, corteccia {TextureCorteccia}";
    }
}
