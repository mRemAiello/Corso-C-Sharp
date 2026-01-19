namespace PatternEDatabase.Strategy;

public sealed class Spedizione
{
    public Spedizione(Ordine ordine, IShippingStrategy strategia)
    {
        Ordine = ordine;
        Strategia = strategia;
    }

    public Ordine Ordine { get; }
    public IShippingStrategy Strategia { get; private set; }

    public decimal CalcolaCosto()
    {
        return Strategia.CalcolaCosto(Ordine);
    }

    public void CambiaStrategia(IShippingStrategy strategia)
    {
        Strategia = strategia;
    }
}
