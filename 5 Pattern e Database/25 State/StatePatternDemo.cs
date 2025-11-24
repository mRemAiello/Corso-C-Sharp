using System;

namespace PatternEDatabase.State;

public static class StatePatternDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Pattern State: gestione di un ordine ===\n");

        var order = new OrderContext();
        StampaStato(order);

        Console.WriteLine("\n> Il cliente paga l'ordine.");
        order.Pay();
        StampaStato(order);

        Console.WriteLine("\n> Il cliente decide di annullare (non possibile perché già pagato).");
        order.Cancel();
        StampaStato(order);

        Console.WriteLine("\n> Il negozio spedisce l'ordine.");
        order.Ship();
        StampaStato(order);

        Console.WriteLine("\n> Tentativo di annullare dopo la spedizione.");
        order.Cancel();
        StampaStato(order);

        Console.WriteLine("\nQuesta sequenza mostra come le azioni vengono inoltrate allo stato attuale dell'ordine " +
                          "e come il contesto cambia comportamento senza usare istruzioni condizionali complesse.");
    }

    private static void StampaStato(OrderContext order)
    {
        Console.WriteLine($"Stato attuale dell'ordine: {order.Status}");
    }
}

// IState -> Context, CanTransitionTo(state), TransitionTo(state), Handle(), Name
// StateManager -> state, TransitionTo(state)
// StateManager.TransitionTo(NewOrderState);