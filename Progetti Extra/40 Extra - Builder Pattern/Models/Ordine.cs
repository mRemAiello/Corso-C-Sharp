namespace ProgettiExtra.BuilderPattern.Models;

public sealed class Ordine
{
    public int Id { get; }
    public ProdottoBuilderPattern Prodotto { get; }
    public int Quantita { get; }
    public DateTime DataOrdine { get; }

    internal Ordine(int id, ProdottoBuilderPattern prodotto, int quantita, DateTime dataOrdine)
    {
        Id = id;
        Prodotto = prodotto;
        Quantita = quantita;
        DataOrdine = dataOrdine;
    }

    public override string ToString() => $"Ordine #{Id} - {Prodotto.Nome} x{Quantita} del {DataOrdine:d}";
}
