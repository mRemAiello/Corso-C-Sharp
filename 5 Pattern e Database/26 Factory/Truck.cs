namespace PatternEDatabase.Factory;

public sealed class Truck : ITransport
{
    public string Deliver(string productName)
    {
        return $"Il camion consegna {productName} via strada.";
    }
}
