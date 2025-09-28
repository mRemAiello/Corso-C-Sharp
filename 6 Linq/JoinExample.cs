namespace LinqExamples;

public record ClienteJoin(int Id, string Nome);

public record OrdineJoin(int ClienteId, string Prodotto);

public static class JoinExample
{
    public static void Execute()
    {
        List<ClienteJoin> clienti = new()
        {
            new(1, "Maria"),
            new(2, "Luca"),
            new(3, "Sara")
        };

        List<OrdineJoin> ordini = new()
        {
            new(1, "Laptop"),
            new(1, "Mouse"),
            new(2, "Monitor"),
            new(4, "Stampante")
        };

        IEnumerable<string> ordiniConCliente = clienti
            .Join(
                ordini,
                cliente => cliente.Id,
                ordine => ordine.ClienteId,
                (cliente, ordine) => $"Cliente: {cliente.Nome} - Prodotto: {ordine.Prodotto}"
            );

        Console.WriteLine("Join - Ordini con relativo cliente:");
        foreach (string risultato in ordiniConCliente)
        {
            Console.WriteLine("- " + risultato);
        }

        Console.WriteLine();
    }
}
