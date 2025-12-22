using System;

namespace PatternEDatabase.Mediator;

/// <summary>
/// Rappresenta uno sviluppatore del team.
/// </summary>
public sealed class Developer : TeamMember
{
    public Developer(string name, IChatMediator mediator) : base(name, mediator)
    {
    }

    public override void Receive(string message, string sender)
    {
        Console.WriteLine($"  -> {Name} (dev) riceve da {sender}: \"{message}\"");
    }
}
