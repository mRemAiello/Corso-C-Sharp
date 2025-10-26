namespace PatternEDatabase.Flyweight;

/// <summary>
/// Albero concreto che contiene le informazioni variabili (stato estrinseco).
/// </summary>
public class Tree
{
    private readonly TreeType _treeType;

    public Tree(TreeType treeType, int posizioneX, int posizioneY, int altezzaMetri)
    {
        _treeType = treeType;
        PosizioneX = posizioneX;
        PosizioneY = posizioneY;
        AltezzaMetri = altezzaMetri;
    }

    public int PosizioneX { get; }
    public int PosizioneY { get; }
    public int AltezzaMetri { get; }

    public string ShowDetails() => _treeType.Describe(PosizioneX, PosizioneY, AltezzaMetri);
}
