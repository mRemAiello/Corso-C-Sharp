using System;

namespace PatternEDatabase.Adapter;

public class LegacySmsSender
{
    public void SendSms(string phoneNumber, string text)
    {
        Console.WriteLine($"SMS inviato al numero {phoneNumber}: {text}");
    }
}
