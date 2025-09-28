using System;

namespace PatternEDatabase.State;

public class NewOrderState : IOrderState
{
    public string Name => "Nuovo";

    public void Pay(OrderContext context)
    {
        Console.WriteLine("Pagamento ricevuto. L'ordine passa allo stato 'Pagato'.");
        context.TransitionTo(new PaidOrderState());
    }

    public void Ship(OrderContext context)
    {
        Console.WriteLine("Impossibile spedire un ordine non ancora pagato.");
    }

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("Ordine annullato prima del pagamento.");
        context.TransitionTo(new CancelledOrderState());
    }
}
