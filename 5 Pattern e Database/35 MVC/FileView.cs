using PatternEDatabase.Mvp;

public class FileViewMVC : ICounterView
{
    public string? ReadCommand()
    {
        throw new NotImplementedException();
    }

    public void ShowGoodbye()
    {
        
    }

    public void ShowUnknownCommand(string command)
    {
        throw new NotImplementedException();
    }

    public void ShowValue(int value)
    {
        throw new NotImplementedException();
    }

    public void ShowWelcome()
    {
        throw new NotImplementedException();
    }
}