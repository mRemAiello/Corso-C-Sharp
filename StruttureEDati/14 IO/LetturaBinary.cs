using System;
using System.IO;

class LetturaBinary
{
    public void Execute()
    {
        string path = "esempio.bin";

        // Verifica se il file esiste
        if (File.Exists(path))
        {
            // Metodo 1:
            /*Stream input = File.Open(path, FileMode.Open);
            BinaryReader reader = new(input);
            var nome = reader.ReadString();
            reader.Close();*/

            // Metodo 2:
            using (BinaryReader reader = new(File.Open(path, FileMode.Open)))
            {
                // Legge un intero dal file
                int numero = reader.ReadInt32();
                Console.WriteLine("Numero letto: " + numero);
            }
        }
        else
        {
            Console.WriteLine("Il file non esiste.");
        }
    }
}
