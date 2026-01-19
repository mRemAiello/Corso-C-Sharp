namespace PatternEDatabase.Composite;

public class Folder : IFileSystemItem
{
    private string _name;
    private int _size;
    private readonly List<IFileSystemItem> _items = [];

    public Folder(string name)
    {
        _name = name;
        _size = 0;
    }

    public string Name => _name;
    public int Size => _size;

    public void Add(IFileSystemItem item)
    {
        _items.Add(item);
        _size += item.Size;
    }

    public void Remove(IFileSystemItem item)
    {
        _items.Remove(item);
        _size -= item.Size;
    }

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
