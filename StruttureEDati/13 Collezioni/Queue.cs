public class Queue
{
    public void Execute()
    {
        // Creazione di una coda di stringhe per rappresentare i clienti in attesa
        Queue<string> clienti = new Queue<string>();

        // Aggiunta di clienti alla coda
        clienti.Enqueue("Mario");
        clienti.Enqueue("Luigi");
        clienti.Enqueue("Peach");

        // Iterazione attraverso la coda e gestione dei clienti
        Console.WriteLine("Gestione dei clienti in coda:");
        while (clienti.Count > 0)
        {
            string cliente = clienti.Dequeue(); // Rimuove e restituisce l'elemento in testa alla coda
            Console.WriteLine("Servito cliente: " + cliente);
        }

        // Controllo se la coda è vuota
        if (clienti.Count == 0)
        {
            Console.WriteLine("Tutti i clienti sono stati serviti.");
        }
    }
}