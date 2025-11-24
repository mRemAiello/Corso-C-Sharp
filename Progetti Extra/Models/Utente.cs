namespace ProgettiExtra.BuilderPattern.Models;

public sealed class Utente
{
    public string Nome { get; }
    public string Cognome { get; }
    public Indirizzo Indirizzo { get; }
    public IReadOnlyCollection<Ordine> Ordini { get; }

    internal Utente(string nome, string cognome, Indirizzo indirizzo, IReadOnlyCollection<Ordine> ordini)
    {
        Nome = nome;
        Cognome = cognome;
        Indirizzo = indirizzo;
        Ordini = ordini;
    }

    public override string ToString() => $"{Nome} {Cognome} - {Indirizzo}";
}
