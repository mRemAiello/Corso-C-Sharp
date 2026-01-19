namespace PatternEDatabase.Composite;

public interface IFileSystemItem
{
    string Name { get; }
    int Size { get; }

    void Print(string indent = "");
}