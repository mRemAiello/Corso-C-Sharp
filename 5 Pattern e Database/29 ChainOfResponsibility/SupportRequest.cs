namespace PatternEDatabase.ChainOfResponsibility;

public sealed class SupportRequest
{
    public SupportRequest(string descrizione, SupportRequestLevel livello)
    {
        Descrizione = descrizione;
        Livello = livello;
    }

    public string Descrizione { get; }

    public SupportRequestLevel Livello { get; }
}
