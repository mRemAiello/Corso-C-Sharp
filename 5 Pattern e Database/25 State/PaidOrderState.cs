using System;

namespace PatternEDatabase.State;

public class PaidOrderState : IOrderState
{
    public string Name => "Pagato";

    public void Pay(OrderContext context)
    {
        Console.WriteLine("L'ordine è già stato pagato.");
    }

    public void Ship(OrderContext context)
    {
        Console.WriteLine("L'ordine è stato spedito al cliente.");
        context.TransitionTo(new ShippedOrderState());
    }

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("Pagamento rimborsato. L'ordine è annullato.");
        context.TransitionTo(new CancelledOrderState());
    }
}