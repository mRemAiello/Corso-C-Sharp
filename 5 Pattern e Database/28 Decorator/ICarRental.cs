namespace PatternEDatabase.Decorator;

public interface ICarRental
{
    string Descrizione { get; }

    decimal CalcolaCosto();
}