public class Lista
{
    public void Execute()
    {
        // Creazione di una lista di stringhe
        string[] valori = { "Ciao", "Ciao2" };
        List<string> frutti = new(valori);

        // Aggiungere elementi alla lista
        frutti.Add("Mela");
        frutti.Add("Banana");
        frutti.Add("Arancia");

        // Accesso agli elementi della lista
        Console.WriteLine("Il primo frutto è: " + frutti[0]);

        // Iterazione attraverso la lista
        Console.WriteLine("Tutti i frutti nella lista:");
        foreach (var frutto in frutti)
        {
            Console.WriteLine(frutto);
        }

        // Rimozione di un elemento dalla lista
        frutti.Remove("Banana");

        // Controllo del numero di elementi nella lista
        Console.WriteLine("Numero di frutti dopo la rimozione: " + frutti.Count);
    }
}