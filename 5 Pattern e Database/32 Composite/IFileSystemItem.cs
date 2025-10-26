namespace PatternEDatabase.Composite;

public interface IFileSystemItem
{
    string Name { get; }

    void Print(string indent = "");
}
