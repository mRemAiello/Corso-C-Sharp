namespace LinqExamples;

public record ClienteGroupJoin(int Id, string Nome);

public record OrdineGroupJoin(int ClienteId, string Prodotto);

public static class GroupJoinExample
{
    public static void Execute()
    {
        List<ClienteGroupJoin> clienti = new()
        {
            new(1, "Maria"),
            new(2, "Luca"),
            new(3, "Sara"),
            new(4, "Giulia")
        };

        List<OrdineGroupJoin> ordini = new()
        {
            new(1, "Laptop"),
            new(1, "Mouse"),
            new(2, "Monitor"),
            new(3, "Stampante")
        };

        IEnumerable<(string Cliente, IEnumerable<OrdineGroupJoin> Ordini)> ordiniPerCliente = clienti
            .GroupJoin(
                ordini,
                cliente => cliente.Id,
                ordine => ordine.ClienteId,
                (cliente, ordiniCliente) => (cliente.Nome, ordiniCliente)
            );

        Console.WriteLine("GroupJoin - Ordini raggruppati per cliente:");
        foreach ((string cliente, IEnumerable<OrdineGroupJoin> ordiniCliente) in ordiniPerCliente)
        {
            Console.WriteLine($"Cliente: {cliente}");
            if (!ordiniCliente.Any())
            {
                Console.WriteLine("  Nessun ordine");
                continue;
            }

            foreach (OrdineGroupJoin ordine in ordiniCliente)
            {
                Console.WriteLine($"  - {ordine.Prodotto}");
            }
        }

        Console.WriteLine();
    }
}
