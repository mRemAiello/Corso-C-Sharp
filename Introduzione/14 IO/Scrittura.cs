using System;
using System.IO;

class Scrittura
{
    public void Execute()
    {
        string path = "esempio.txt";
        string contenuto = "Ciao, questo è un esempio di scrittura su file.";

        // Esempio di scrittura di un array di stringhe
        /*foreach (Persona persona in persona)
        {
            contenuto += persona.ToString();
            contenuto += Environment.NewLine;
        }*/

        // Nome: Mario
        // Cognome: Rossi
        // ...
        //
        // Nome: Luigi
        // Cognome: Verdi

        // Scrive il contenuto nel file
        File.WriteAllText(path, contenuto);

        Console.WriteLine("File scritto con successo.");
    }
}
