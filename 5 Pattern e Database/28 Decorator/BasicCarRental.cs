namespace PatternEDatabase.Decorator;

public class BasicCarRental : ICarRental
{
    public string Descrizione => "Utilitaria 5 porte";

    public decimal CalcolaCosto() => 39.90m;
}
