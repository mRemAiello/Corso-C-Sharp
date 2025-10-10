public class SenderSMS
{
    public void Send(string message, string phoneNumber)
    {
        Console.WriteLine($"Invio SMS a {phoneNumber}: {message}");
    }
}