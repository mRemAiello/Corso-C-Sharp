using System;
using System.IO;

class ScritturaBinary
{
    public void Execute()
    {
        string path = "esempio.bin";
        int numero = 42;

        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
        {
            // Scrive un intero nel file
            writer.Write(numero);
        }

        Console.WriteLine("File binario scritto con successo.");
    }
}