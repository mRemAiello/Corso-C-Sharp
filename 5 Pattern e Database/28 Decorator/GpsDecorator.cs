namespace PatternEDatabase.Decorator;

public class GpsDecorator : CarRentalDecorator
{
    public GpsDecorator(ICarRental inner) : base(inner)
    {
    }

    public override string Descrizione => base.Descrizione + ", Navigatore GPS";

    public override decimal CalcolaCosto() => base.CalcolaCosto() + 4.50m;
}
