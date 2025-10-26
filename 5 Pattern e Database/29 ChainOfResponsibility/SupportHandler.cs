using System;

namespace PatternEDatabase.ChainOfResponsibility;

public abstract class SupportHandler
{
    private SupportHandler? _next;

    public SupportHandler SetNext(SupportHandler next)
    {
        _next = next;
        return next;
    }

    public void Handle(SupportRequest request)
    {
        if (CanHandle(request))
        {
            Process(request);
        }
        else if (_next is not null)
        {
            Console.WriteLine($"Non posso aiutare con: {request.Descrizione}. Passo al livello successivo...");
            _next.Handle(request);
        }
        else
        {
            Console.WriteLine($"Nessuno ha potuto gestire la richiesta: {request.Descrizione}\n");
        }
    }

    protected abstract bool CanHandle(SupportRequest request);

    protected abstract void Process(SupportRequest request);
}
