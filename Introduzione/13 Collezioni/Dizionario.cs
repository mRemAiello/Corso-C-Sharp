public class Dizionario
{
    public void Execute()
    {
        // Creazione di un dizionario che associa nomi di persone a età
        Dictionary<string, int> etàPersone = new Dictionary<string, int>();

        // Aggiungere coppie chiave-valore al dizionario
        etàPersone["Mario"] = 30;
        etàPersone["Luigi"] = 28;
        etàPersone["Peach"] = 25;

        // Accesso a un valore tramite la chiave
        Console.WriteLine("L'età di Luigi è: " + etàPersone["Luigi"]);

        // Iterazione attraverso il dizionario
        Console.WriteLine("Tutte le persone nel dizionario:");
        foreach (var persona in etàPersone)
        {
            Console.WriteLine(persona.Key + " ha " + persona.Value + " anni.");
        }

        // Verifica se una chiave esiste nel dizionario
        if (etàPersone.ContainsKey("Peach"))
        {
            Console.WriteLine("Peach è nel dizionario.");
        }

        // Rimozione di una coppia chiave-valore dal dizionario
        etàPersone.Remove("Mario");

        // Controllo del numero di elementi nel dizionario
        Console.WriteLine("Numero di persone dopo la rimozione: " + etàPersone.Count);
    }
}