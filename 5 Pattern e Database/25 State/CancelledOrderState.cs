using System;

namespace PatternEDatabase.State;

public class CancelledOrderState : IOrderState
{
    public string Name => "Annullato";

    public void Pay(OrderContext context)
    {
        Console.WriteLine("Un ordine annullato non può essere pagato.");
    }

    public void Ship(OrderContext context)
    {
        Console.WriteLine("Un ordine annullato non può essere spedito.");
    }

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("L'ordine è già annullato.");
    }
}
