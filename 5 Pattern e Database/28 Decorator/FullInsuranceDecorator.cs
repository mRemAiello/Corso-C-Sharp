namespace PatternEDatabase.Decorator;

public class FullInsuranceDecorator : CarRentalDecorator
{
    public FullInsuranceDecorator(ICarRental inner) : base(inner)
    {
    }

    public override string Descrizione => base.Descrizione + ", Assicurazione Kasko";

    public override decimal CalcolaCosto() => base.CalcolaCosto() + 15.00m;
}
