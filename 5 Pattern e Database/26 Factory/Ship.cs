namespace PatternEDatabase.Factory;

public sealed class Ship : ITransport
{
    public string Deliver(string productName)
    {
        return $"La nave consegna {productName} via mare.";
    }
}
