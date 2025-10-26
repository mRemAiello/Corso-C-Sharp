using System;
using System.Collections.Generic;

namespace PatternEDatabase.ChainOfResponsibility;

public static class ChainOfResponsibilityPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Chain of Responsibility ===");
        Console.WriteLine("La Chain of Responsibility collega più gestori. Ogni gestore decide se processare la richiesta oppure delegarla al successivo.\n");

        var helpDesk = new BasicSupportHandler();
        var tecnico = new TechnicalSupportHandler();
        var manager = new ManagerSupportHandler();
        helpDesk.SetNext(tecnico).SetNext(manager);

        var richieste = new List<SupportRequest>
        {
            new("Ho dimenticato la password", SupportRequestLevel.DiBase),
            new("L'applicazione si blocca all'avvio", SupportRequestLevel.Tecnica),
            new("Il sistema principale è irraggiungibile", SupportRequestLevel.Critica)
        };

        foreach (var richiesta in richieste)
        {
            helpDesk.Handle(richiesta);
        }
    }
}
