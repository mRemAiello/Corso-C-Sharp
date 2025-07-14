public class ChiaveMagnetica : ChiaveConLunghezza
{
    private float _ampiezza;

    public ChiaveMagnetica(string? descrizione, float peso, float lunghezza, float ampiezza) : base(descrizione, peso, lunghezza)
    {
        _ampiezza = ampiezza;
    }

    //
    public float GetAmpiezza() => _ampiezza;

    //
    public override string ToString()
    {
        return base.ToString() + " - Ampiezza: " + _ampiezza;
    }
}