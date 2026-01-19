namespace PatternEDatabase.Strategy;

public sealed class Ordine
{
    public Ordine(decimal pesoKg, int distanzaKm, decimal valoreMerce)
    {
        PesoKg = pesoKg;
        DistanzaKm = distanzaKm;
        ValoreMerce = valoreMerce;
    }

    public decimal PesoKg { get; }
    public int DistanzaKm { get; }
    public decimal ValoreMerce { get; }
}
