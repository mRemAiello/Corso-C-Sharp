using System;

namespace PatternEDatabase.Mediator;

/// <summary>
/// Rappresenta un membro di un team che comunica tramite il mediatore.
/// </summary>
public abstract class TeamMember
{
    private readonly IChatMediator _mediator;

    protected TeamMember(string name, IChatMediator mediator)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        _mediator.Register(this);
    }

    /// <summary>
    /// Nome leggibile del membro.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Invia un messaggio tramite il mediatore condiviso.
    /// </summary>
    /// <param name="message">Testo del messaggio.</param>
    public void Send(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            throw new ArgumentException("Il messaggio non può essere vuoto.", nameof(message));
        }

        Console.WriteLine($"[{Name} invia]: {message}");
        _mediator.Send(message, this);
    }

    /// <summary>
    /// Riceve un messaggio inoltrato dal mediatore.
    /// </summary>
    /// <param name="message">Testo del messaggio.</param>
    /// <param name="sender">Nome del mittente.</param>
    public abstract void Receive(string message, string sender);
}
