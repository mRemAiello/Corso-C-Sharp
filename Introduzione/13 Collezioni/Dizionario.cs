public class Dizionario
{
    public void Execute()
    {
        // Creazione di un dizionario che associa nomi di persone a età
        Dictionary<string, int> etaPersone = new();

        // Aggiungere coppie chiave-valore al dizionario
        etaPersone["Mario"] = 30;
        etaPersone["Luigi"] = 28;
        etaPersone["Peach"] = 25;
        etaPersone["Mario"] = 35;

        // Accesso a un valore tramite la chiave
        Console.WriteLine("L'età di Luigi è: " + etaPersone["Luigi"]);

        // Iterazione attraverso il dizionario
        Console.WriteLine("Tutte le persone nel dizionario:");
        foreach (var persona in etaPersone)
        {
            // persona = KeyValuePair<string, int>
            Console.WriteLine(persona.Key + " ha " + persona.Value + " anni.");
        }

        // Verifica se una chiave esiste nel dizionario
        if (etaPersone.ContainsKey("Peach"))
        {
            Console.WriteLine("Peach è nel dizionario.");
        }

        // Rimozione di una coppia chiave-valore dal dizionario
        etaPersone.Remove("Mario");

        // Controllo del numero di elementi nel dizionario
        Console.WriteLine("Numero di persone dopo la rimozione: " + etaPersone.Count);
    }
}