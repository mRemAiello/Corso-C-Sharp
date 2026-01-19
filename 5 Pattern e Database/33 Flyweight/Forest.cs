using System.Collections.Generic;
using System.Linq;

namespace PatternEDatabase.Flyweight;

/// <summary>
/// Contenitore che utilizza il factory per riutilizzare i tipi di albero condivisi.
/// </summary>
public class Forest
{
    private readonly List<Tree> _trees = [];
    private readonly TreeFactory _factory = new();

    public void PlantTree(int posizioneX, int posizioneY, int altezzaMetri, string specie, string coloreFoglie, string textureCorteccia)
    {
        var treeType = _factory.GetTreeType(specie, coloreFoglie, textureCorteccia);
        _trees.Add(new Tree(treeType, posizioneX, posizioneY, altezzaMetri));
    }

    public IEnumerable<string> DescribeTrees() => _trees.Select(tree => tree.ShowDetails());

    public int CountTrees() => _trees.Count;

    public int CountTreeTypes() => _factory.CountCreatedTypes();
}
