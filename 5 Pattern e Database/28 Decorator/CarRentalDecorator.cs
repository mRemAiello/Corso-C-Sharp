namespace PatternEDatabase.Decorator;

public abstract class CarRentalDecorator : ICarRental
{
    private ICarRental _inner;

    protected CarRentalDecorator(ICarRental inner)
    {
        _inner = inner;
    }

    public void SetInner(ICarRental inner)
    {
        _inner = inner;
    }

    public virtual string Descrizione => _inner.Descrizione;
    public virtual decimal CalcolaCosto() => _inner.CalcolaCosto();
}
