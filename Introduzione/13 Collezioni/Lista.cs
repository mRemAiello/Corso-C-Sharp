public class Lista
{
    public void Execute()
    {
        // Memoria: 0x0001 -> 0x0021
        // PrimoElemento, 10 x stringa
        string[] valori = ["Ciao", "Ciao2"];

        // lista -> Nodo1 (3, 0x00020) -> Nodo2 (3, 0x00015) -> Nodo3 (50, null)
        // PrimoElemento, 10 x stringa, 10 x Nodo, 10 x Successivo
        List<string> frutti = new(valori);

        // Aggiungere elementi alla lista
        frutti.Add("Mela");
        frutti.Add("Banana");
        frutti.Add("Arancia");

        // Accesso agli elementi della lista
        Console.WriteLine("Il primo frutto è: " + frutti[0]);

        // Iterazione attraverso la lista
        Console.WriteLine("Tutti i frutti nella lista:");
        foreach (string frutto in frutti)
        {
            Console.WriteLine(frutto);
        }

        // Rimozione di un elemento dalla lista
        frutti.Remove("Banana");

        // Add Multiplo
        frutti.AddRange(valori);

        // Controllo se un elemento esiste nella lista
        if (frutti.Contains("Ciao1"))
        {
            Console.WriteLine("Ciao1 è presente nella lista.");
        }
        else
        {
            Console.WriteLine("Ciao1 non è presente nella lista.");
        }

        // Trasformo in array
        string[] array = frutti.ToArray();

        // Controllo del numero di elementi nella lista
        Console.WriteLine("Numero di frutti dopo la rimozione: " + frutti.Count);
    }
}