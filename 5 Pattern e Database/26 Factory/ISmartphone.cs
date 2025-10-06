namespace PatternEDatabase.Factory;

public interface ISmartphone
{
    string Name { get; }
    string Call(string contactName);
}
