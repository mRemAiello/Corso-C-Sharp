using System;

namespace PatternEDatabase.Adapter;

public class EmailNotificationService : INotificationService
{
    public void Send(string destinatario, string messaggio)
    {
        Console.WriteLine($"Email inviata a {destinatario}: {messaggio}");
    }
}
