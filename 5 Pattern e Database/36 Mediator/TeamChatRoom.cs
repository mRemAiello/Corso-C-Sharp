using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternEDatabase.Mediator;

/// <summary>
/// Implementazione concreta del mediatore: gestisce la comunicazione tra i membri del team.
/// </summary>
public sealed class TeamChatRoom : IChatMediator
{
    private readonly IList<TeamMember> _members = new List<TeamMember>();

    public void Register(TeamMember member)
    {
        ArgumentNullException.ThrowIfNull(member);

        if (_members.Any(m => m.Name.Equals(member.Name, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"[Chat] {member.Name} è già presente nella stanza, registrazione ignorata.");
            return;
        }

        _members.Add(member);
        Console.WriteLine($"[Chat] {member.Name} si è unito alla stanza.");
    }

    public void Send(string message, TeamMember sender)
    {
        ArgumentNullException.ThrowIfNull(sender);
        ArgumentNullException.ThrowIfNull(message);

        foreach (var member in _members.Where(member => !ReferenceEquals(member, sender)))
        {
            member.Receive(message, sender.Name);
        }
    }
}
