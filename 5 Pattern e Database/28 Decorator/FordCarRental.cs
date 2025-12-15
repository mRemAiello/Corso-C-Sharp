namespace PatternEDatabase.Decorator;

public class FordCarRental : ICarRental
{
    public string Descrizione => "Ford 4 porte";
    public decimal CalcolaCosto() => 59.90m;
}
