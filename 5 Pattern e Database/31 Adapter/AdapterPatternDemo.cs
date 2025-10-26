using System;

namespace PatternEDatabase.Adapter;

public static class AdapterPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("Esempio Adapter: uniformiamo l'invio di notifiche.\n");

        INotificationService email = new EmailNotificationService();
        INotificationService sms = new SmsNotificationAdapter(new LegacySmsSender());

        InviaPromemoria(email, "alice@example.com");
        Console.WriteLine();
        InviaPromemoria(sms, "+39 123 456 7890");

        Console.WriteLine("\nGrazie all'Adapter possiamo riutilizzare servizi esistenti senza modificarli.");
    }

    private static void InviaPromemoria(INotificationService notificationService, string destinatario)
    {
        Console.WriteLine($"Invio promemoria a {destinatario}...");
        notificationService.Send(destinatario, "Domani riunione alle 9:00.");
    }
}
