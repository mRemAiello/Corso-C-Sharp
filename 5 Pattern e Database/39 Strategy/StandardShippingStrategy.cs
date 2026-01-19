namespace PatternEDatabase.Strategy;

public sealed class StandardShippingStrategy : IShippingStrategy
{
    public string Nome => "Standard";

    public decimal CalcolaCosto(Ordine ordine)
    {
        var baseCosto = 5m;
        var costoPeso = ordine.PesoKg * 1.2m;
        var costoDistanza = ordine.DistanzaKm * 0.05m;
        return baseCosto + costoPeso + costoDistanza;
    }
}
