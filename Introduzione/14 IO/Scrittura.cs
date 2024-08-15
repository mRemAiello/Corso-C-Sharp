using System;
using System.IO;

class Scrittura
{
    public void Execute()
    {
        string path = "esempio.txt";
        string contenuto = "Ciao, questo è un esempio di scrittura su file.";

        // Scrive il contenuto nel file
        File.WriteAllText(path, contenuto);

        Console.WriteLine("File scritto con successo.");
    }
}
