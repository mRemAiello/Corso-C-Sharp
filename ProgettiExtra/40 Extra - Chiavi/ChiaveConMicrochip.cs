public class ChiaveConMicrochip : Chiave
{
    private string _codiceSeriale;

    public ChiaveConMicrochip(string? descrizione, float peso, string codiceSeriale) : base(descrizione, peso)
    {
        _codiceSeriale = codiceSeriale;
    }

    //
    public string GetSeriale() => _codiceSeriale;
    public void CambiaSeriale(string codiceSeriale) => _codiceSeriale = codiceSeriale;

    //
    public override string ToString()
    {
        return base.ToString() + " - Codice Seriale: " + _codiceSeriale;
    }
}