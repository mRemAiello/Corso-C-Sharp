namespace PatternEDatabase.Decorator;

public class AdditionalDriverDecorator : CarRentalDecorator
{
    public AdditionalDriverDecorator(ICarRental inner) : base(inner)
    {
    }

    public override string Descrizione => base.Descrizione + ", Conducente aggiuntivo";

    public override decimal CalcolaCosto() => base.CalcolaCosto() + 6.00m;
}
