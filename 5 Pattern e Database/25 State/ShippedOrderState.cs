using System;

namespace PatternEDatabase.State;

public class ShippedOrderState : IOrderState
{
    public string Name => "Spedito";

    public void Pay(OrderContext context)
    {
        Console.WriteLine("L'ordine è già stato pagato e spedito.");
    }

    public void Ship(OrderContext context)
    {
        Console.WriteLine("L'ordine è già stato spedito.");
        context.TransitionTo(new DeliveredOrderState());
    }

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("Non è possibile annullare un ordine già spedito.");
    }
}
