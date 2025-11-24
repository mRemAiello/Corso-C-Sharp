namespace ProgettiExtra.BuilderPattern.Models;

public sealed class Prodotto
{
    public int Id { get; }
    public string Nome { get; }
    public decimal Prezzo { get; }

    internal Prodotto(int id, string nome, decimal prezzo)
    {
        Id = id;
        Nome = nome;
        Prezzo = prezzo;
    }

    public override string ToString() => $"{Nome} (#{Id}) - {Prezzo:C}";
}
