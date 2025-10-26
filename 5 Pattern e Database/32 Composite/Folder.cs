namespace PatternEDatabase.Composite;

public class Folder(string name) : IFileSystemItem
{
    private readonly List<IFileSystemItem> _items = new();

    public string Name { get; } = name;

    public void Add(IFileSystemItem item) => _items.Add(item);

    public void Remove(IFileSystemItem item) => _items.Remove(item);

    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}+ {Name}");
        var nextIndent = indent + "  ";

        foreach (var item in _items)
        {
            item.Print(nextIndent);
        }
    }
}
