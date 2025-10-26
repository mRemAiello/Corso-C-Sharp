using System;

namespace PatternEDatabase.ChainOfResponsibility;

public sealed class ManagerSupportHandler : SupportHandler
{
    protected override bool CanHandle(SupportRequest request) => request.Livello == SupportRequestLevel.Critica;

    protected override void Process(SupportRequest request)
    {
        Console.WriteLine($"[Responsabile] Gestisco personalmente la richiesta critica: {request.Descrizione}\n");
    }
}
