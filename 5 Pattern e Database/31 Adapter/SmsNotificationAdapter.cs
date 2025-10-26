using System;

namespace PatternEDatabase.Adapter;

public class SmsNotificationAdapter : INotificationService
{
    private readonly LegacySmsSender _smsSender;

    public SmsNotificationAdapter(LegacySmsSender smsSender)
    {
        _smsSender = smsSender ?? throw new ArgumentNullException(nameof(smsSender));
    }

    public void Send(string destinatario, string messaggio)
    {
        Console.WriteLine("Adapter: converto la richiesta generica in un SMS specifico.");
        _smsSender.SendSms(destinatario, messaggio);
    }
}
