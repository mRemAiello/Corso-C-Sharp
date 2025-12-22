using System;

namespace PatternEDatabase.Mediator;

/// <summary>
/// Rappresenta un project manager che coordina il lavoro del team.
/// </summary>
public sealed class ProjectManager : TeamMember
{
    public ProjectManager(string name, IChatMediator mediator) : base(name, mediator)
    {
    }

    public override void Receive(string message, string sender)
    {
        Console.WriteLine($"  -> {Name} (PM) prende nota del messaggio di {sender}: \"{message}\"");
    }
}
