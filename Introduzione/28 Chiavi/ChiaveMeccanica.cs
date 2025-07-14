public class ChiaveMeccanica : ChiaveConLunghezza
{
    private int _numeroDentelli;

    public ChiaveMeccanica(string? descrizione, float peso, float lunghezza, int numeroDentelli) : base(descrizione, peso, lunghezza)
    {
        _numeroDentelli = numeroDentelli;
    }

    //
    public int GetNumeroDentelli() => _numeroDentelli;

    //
    public override string ToString()
    {
        string str = base.ToString() + " - N° Dentelli: " + _numeroDentelli;
        return str;
    }
}