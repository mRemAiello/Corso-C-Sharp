namespace PatternEDatabase.Strategy;

public sealed class ExpressShippingStrategy : IShippingStrategy
{
    public string Nome => "Express";

    public decimal CalcolaCosto(Ordine ordine)
    {
        var baseCosto = 12m;
        var costoPeso = ordine.PesoKg * 1.8m;
        var costoDistanza = ordine.DistanzaKm * 0.08m;
        var assicurazione = ordine.ValoreMerce * 0.01m;
        return baseCosto + costoPeso + costoDistanza + assicurazione;
    }
}
