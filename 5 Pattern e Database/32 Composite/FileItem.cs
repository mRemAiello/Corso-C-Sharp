namespace PatternEDatabase.Composite;

public class FileItem(string name) : IFileSystemItem
{
    public string Name { get; } = name;

    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}- {Name}");
    }
}
