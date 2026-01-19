namespace PatternEDatabase.Composite;

public class FileItem(string name, int size) : IFileSystemItem
{
    public string Name { get; } = name;
    public int Size { get; } = size;

    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}- {Name} ({Size} bytes)");
    }
}
