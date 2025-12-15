namespace PatternEDatabase.Decorator;

public class FerrariCarRental : ICarRental
{
    public string Descrizione => "Ferrari 4 porte";
    public decimal CalcolaCosto() => 139.90m;
}
