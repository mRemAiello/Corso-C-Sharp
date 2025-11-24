namespace ProgettiExtra.BuilderPattern.Models;

public sealed class Indirizzo
{
    public string Via { get; }
    public string Civico { get; }
    public string Citta { get; }
    public string Provincia { get; }
    public string Cap { get; }

    internal Indirizzo(string via, string civico, string citta, string provincia, string cap)
    {
        Via = via;
        Civico = civico;
        Citta = citta;
        Provincia = provincia;
        Cap = cap;
    }

    public override string ToString() => $"{Via}, {Civico} - {Cap} {Citta} ({Provincia})";
}
