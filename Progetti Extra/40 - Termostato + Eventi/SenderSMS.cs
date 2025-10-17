public class SenderSMS
{
    private static SenderSMS? _instance = null;

    protected SenderSMS()
    {
    }

    public static SenderSMS Instance
    {
        get
        {
            if (_instance == null)
                _instance = new SenderSMS();

            return _instance;
        }
    }

    public void Send(string phoneNumber, string message)
    {
        Console.WriteLine($"Invio SMS al numero {phoneNumber}: {message}");
    }
}