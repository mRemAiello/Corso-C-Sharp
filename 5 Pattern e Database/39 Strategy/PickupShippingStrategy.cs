namespace PatternEDatabase.Strategy;

public sealed class PickupShippingStrategy : IShippingStrategy
{
    public string Nome => "Ritiro in sede";

    public decimal CalcolaCosto(Ordine ordine)
    {
        return 0m;
    }
}
