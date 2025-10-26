namespace PatternEDatabase.Adapter;

public interface INotificationService
{
    void Send(string destinatario, string messaggio);
}
