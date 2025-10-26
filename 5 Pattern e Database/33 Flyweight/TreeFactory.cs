using System.Collections.Generic;

namespace PatternEDatabase.Flyweight;

/// <summary>
/// Crea e riutilizza gli oggetti TreeType (i flyweight) evitando duplicati.
/// </summary>
public class TreeFactory
{
    private readonly Dictionary<string, TreeType> _treeTypes = new();

    public TreeType GetTreeType(string specie, string coloreFoglie, string textureCorteccia)
    {
        var key = $"{specie}-{coloreFoglie}-{textureCorteccia}".ToLowerInvariant();

        if (!_treeTypes.TryGetValue(key, out var treeType))
        {
            treeType = new TreeType(specie, coloreFoglie, textureCorteccia);
            _treeTypes[key] = treeType;
        }

        return treeType;
    }

    public int CountCreatedTypes() => _treeTypes.Count;
}
