public class ChiaveConLunghezza : Chiave
{
    private float _lunghezza;

    public ChiaveConLunghezza(string? descrizione, float peso, float lunghezza) : base(descrizione, peso)
    {
        _lunghezza = lunghezza;
    }

    //
    public float GetLunghezza() => _lunghezza;

    //
    public override string ToString()
    {
        return $"{base.ToString()} - Lunghezza: {_lunghezza}";
    }
}