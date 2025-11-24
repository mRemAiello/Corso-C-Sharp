using ProgettiExtra.BuilderPattern.Models;

namespace ProgettiExtra.BuilderPattern.Builders;

public sealed class ProdottoBuilder
{
    private int? _id;
    private string? _nome;
    private decimal? _prezzo;

    public ProdottoBuilder ConId(int id)
    {
        _id = id;
        return this;
    }

    public ProdottoBuilder ConNome(string nome)
    {
        _nome = nome;
        return this;
    }

    public ProdottoBuilder ConPrezzo(decimal prezzo)
    {
        _prezzo = prezzo;
        return this;
    }

    public Prodotto Build()
    {
        if (_id is null || _id <= 0)
        {
            throw new InvalidOperationException("L'id del prodotto deve essere positivo.");
        }

        if (string.IsNullOrWhiteSpace(_nome))
        {
            throw new InvalidOperationException("Il nome del prodotto è obbligatorio.");
        }

        if (_prezzo is null || _prezzo < 0)
        {
            throw new InvalidOperationException("Il prezzo del prodotto non può essere negativo.");
        }

        return new Prodotto(_id.Value, _nome.Trim(), _prezzo.Value);
    }
}
