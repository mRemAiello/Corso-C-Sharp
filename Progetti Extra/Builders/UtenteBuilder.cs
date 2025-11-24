using ProgettiExtra.BuilderPattern.Models;

namespace ProgettiExtra.BuilderPattern.Builders;

public sealed class UtenteBuilder
{
    private readonly string _nome;
    private readonly string _cognome;
    private Indirizzo? _indirizzo;
    private readonly List<Ordine> _ordini = new();

    public UtenteBuilder(string nome, string cognome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("Il nome è obbligatorio.", nameof(nome));
        }

        if (string.IsNullOrWhiteSpace(cognome))
        {
            throw new ArgumentException("Il cognome è obbligatorio.", nameof(cognome));
        }

        _nome = nome.Trim();
        _cognome = cognome.Trim();
    }

    public UtenteBuilder ConIndirizzo(Indirizzo indirizzo)
    {
        _indirizzo = indirizzo ?? throw new ArgumentNullException(nameof(indirizzo));
        return this;
    }

    public UtenteBuilder AggiungiOrdine(Ordine ordine)
    {
        _ordini.Add(ordine ?? throw new ArgumentNullException(nameof(ordine)));
        return this;
    }

    public UtenteBuilder AggiungiOrdini(IEnumerable<Ordine> ordini)
    {
        if (ordini is null)
        {
            throw new ArgumentNullException(nameof(ordini));
        }

        _ordini.AddRange(ordini);
        return this;
    }

    public Utente Build()
    {
        if (_indirizzo is null)
        {
            throw new InvalidOperationException("Impossibile costruire un utente senza indirizzo.");
        }

        return new Utente(_nome, _cognome, _indirizzo, _ordini.AsReadOnly());
    }
}
