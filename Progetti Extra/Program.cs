using ProgettiExtra.BuilderPattern.Builders;
using ProgettiExtra.BuilderPattern.Models;

Console.WriteLine("Esempio di creazione di utenti e ordini con il Builder Pattern\n");

Indirizzo indirizzo = new IndirizzoBuilder()
    .ConVia("Via dei Platani")
    .ConCivico("15B")
    .ConCitta("Roma")
    .ConProvincia("RM")
    .ConCap("00100")
    .Build();

Prodotto notebook = new ProdottoBuilder()
    .ConId(1)
    .ConNome("Notebook Ultrabook 14\"")
    .ConPrezzo(1299.90m)
    .Build();

Prodotto mouse = new ProdottoBuilder()
    .ConId(2)
    .ConNome("Mouse Bluetooth")
    .ConPrezzo(39.90m)
    .Build();

Ordine primoOrdine = new OrdineBuilder()
    .ConId(1001)
    .ConProdotto(notebook)
    .ConQuantita(1)
    .ConDataOrdine(DateTime.Today.AddDays(-7))
    .Build();

Ordine secondoOrdine = new OrdineBuilder()
    .ConId(1002)
    .ConProdotto(mouse)
    .ConQuantita(2)
    .ConDataOrdine(DateTime.Today.AddDays(-2))
    .Build();

Utente utente = new UtenteBuilder("Mario", "Rossi")
    .ConIndirizzo(indirizzo)
    .AggiungiOrdini(new[] { primoOrdine, secondoOrdine })
    .Build();

Console.WriteLine($"Utente creato: {utente}\n");
Console.WriteLine("Ordini effettuati:");
foreach (Ordine ordine in utente.Ordini)
{
    Console.WriteLine($" - {ordine} -> {ordine.Prodotto}");
}
