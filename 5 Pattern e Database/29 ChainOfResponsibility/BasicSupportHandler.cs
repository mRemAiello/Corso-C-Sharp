using System;

namespace PatternEDatabase.ChainOfResponsibility;

public sealed class BasicSupportHandler : SupportHandler
{
    protected override bool CanHandle(SupportRequest request) => request.Livello == SupportRequestLevel.DiBase;

    protected override void Process(SupportRequest request)
    {
        Console.WriteLine($"[Help Desk] Risolvo il problema di base: {request.Descrizione}\n");
    }
}
