public class LogWriter
{
    private static LogWriter? _instance = null;

    protected LogWriter()
    {
    }

    public static LogWriter Instance
    {
        get
        {
            if (_instance == null)
                _instance = new LogWriter();

            return _instance;
        }
    }

    public void WriteLine(string message)
    {
        // TODO: Scrivere su un file
        Console.WriteLine(message);
    }
}