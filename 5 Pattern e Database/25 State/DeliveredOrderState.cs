using PatternEDatabase.State;

public class DeliveredOrderState : IOrderState
{
    public string Name => "Ordine consegnato";

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("L'ordine è consegnato, non puoi cancellarlo");
    }

    public void Pay(OrderContext context)
    {
        Console.WriteLine("L'ordine è già pagato e consegnato, non devi fare altro");
    }

    public void Ship(OrderContext context)
    {
        Console.WriteLine("L'ordine è già consegnato");
    }
}