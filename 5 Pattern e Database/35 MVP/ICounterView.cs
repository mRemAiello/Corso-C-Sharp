namespace PatternEDatabase.Mvp;

/// <summary>
/// Contratto minimo per la vista del pattern MVP.
/// </summary>
public interface ICounterView
{
    void ShowWelcome();
    void ShowValue(int value);
    void ShowUnknownCommand(string command);
    string? ReadCommand();
    void ShowGoodbye();
}
