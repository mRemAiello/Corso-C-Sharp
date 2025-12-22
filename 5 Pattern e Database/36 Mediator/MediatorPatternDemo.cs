using System;
using System.Collections.Generic;

namespace PatternEDatabase.Mediator;

/// <summary>
/// Dimostrazione concreta del pattern Mediator usando una chat interna al team.
/// </summary>
public static class MediatorPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Mediator Pattern: Team Chat ===");
        Console.WriteLine("Il mediatore centralizza la comunicazione tra i componenti del team, evitando riferimenti diretti tra loro.\n");

        var chatRoom = new TeamChatRoom();

        var members = new List<TeamMember>
        {
            new Developer("Alice", chatRoom),
            new Developer("Bruno", chatRoom),
            new ProjectManager("Chiara", chatRoom)
        };

        members[0].Send("Ho refactorizzato il modulo di autenticazione.");
        members[2].Send("Grazie Alice, Bruno puoi eseguire i test end-to-end?");
        members[1].Send("Ricevuto! Li faccio partire sulla pipeline di staging.");
    }
}
