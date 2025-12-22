namespace PatternEDatabase.Mediator;

/// <summary>
/// Definisce l'interfaccia del mediatore, che coordina la comunicazione tra i colleghi.
/// </summary>
public interface IChatMediator
{
    /// <summary>
    /// Registra un nuovo partecipante nella chat.
    /// </summary>
    /// <param name="member">Il membro da aggiungere.</param>
    void Register(TeamMember member);

    /// <summary>
    /// Invia un messaggio dal mittente a tutti gli altri partecipanti.
    /// </summary>
    /// <param name="message">Il testo del messaggio.</param>
    /// <param name="sender">Il mittente.</param>
    void Send(string message, TeamMember sender);
}
