namespace PatternEDatabase.Factory;

public abstract class Logistics
{
    public string PlanDelivery(string productName)
    {
        var transport = CreateTransport();
        return $"Preparazione spedizione: {transport.Deliver(productName)}";
    }

    protected abstract ITransport CreateTransport();
}
