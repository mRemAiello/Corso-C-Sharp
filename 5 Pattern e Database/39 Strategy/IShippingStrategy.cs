namespace PatternEDatabase.Strategy;

public interface IShippingStrategy
{
    string Nome { get; }

    decimal CalcolaCosto(Ordine ordine);
}
