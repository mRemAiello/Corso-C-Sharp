using ProgettiExtra.BuilderPattern.Models;

namespace ProgettiExtra.BuilderPattern.Builders;

public sealed class OrdineBuilder
{
    private int? _id;
    private Prodotto? _prodotto;
    private int _quantita = 1;
    private DateTime _data = DateTime.Today;

    public OrdineBuilder ConId(int id)
    {
        _id = id;
        return this;
    }

    public OrdineBuilder ConProdotto(Prodotto prodotto)
    {
        _prodotto = prodotto;
        return this;
    }

    public OrdineBuilder ConQuantita(int quantita)
    {
        _quantita = quantita;
        return this;
    }

    public OrdineBuilder ConDataOrdine(DateTime data)
    {
        _data = data;
        return this;
    }

    public Ordine Build()
    {
        if (_id is null || _id <= 0)
        {
            throw new InvalidOperationException("L'id dell'ordine deve essere positivo.");
        }

        if (_prodotto is null)
        {
            throw new InvalidOperationException("L'ordine deve avere un prodotto associato.");
        }

        if (_quantita <= 0)
        {
            throw new InvalidOperationException("La quantità deve essere almeno 1.");
        }

        return new Ordine(_id.Value, _prodotto, _quantita, _data);
    }
}
