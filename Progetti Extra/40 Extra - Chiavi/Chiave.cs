public abstract class Chiave
{
    private string? _descrizione;
    private float _peso;

    public Chiave(string? descrizione, float peso)
    {
        _descrizione = descrizione;
        _peso = peso;
    }

    //
    public float GetPeso() => _peso;
    public string? GetDescrizione() => _descrizione;
    public void SetDescrizione(string? descrizione) => _descrizione = descrizione;

    //
    public override string ToString()
    {
        return $"Descrizione: {_descrizione} - Peso: {_peso}";
    }
}