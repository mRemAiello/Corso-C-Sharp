using System;

namespace PatternEDatabase.ChainOfResponsibility;

public sealed class TechnicalSupportHandler : SupportHandler
{
    protected override bool CanHandle(SupportRequest request) => request.Livello == SupportRequestLevel.Tecnica;

    protected override void Process(SupportRequest request)
    {
        Console.WriteLine($"[Supporto Tecnico] Analizzo e risolvo il problema tecnico: {request.Descrizione}\n");
    }
}
