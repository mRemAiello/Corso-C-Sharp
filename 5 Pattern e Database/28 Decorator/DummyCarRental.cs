namespace PatternEDatabase.Decorator;

public class DummyCardRental : ICarRental
{
    public string Descrizione => "";
    public decimal CalcolaCosto() => 0m;
}