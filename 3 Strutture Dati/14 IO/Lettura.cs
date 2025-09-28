class Lettura
{
    public void Execute()
    {
        string path = "esempio.txt";

        // Verifica se il file esiste
        if (File.Exists(path))
        {
            // Legge tutto il contenuto del file
            string contenuto = File.ReadAllText(path);
            Console.WriteLine(contenuto);
        }
        else
        {
            Console.WriteLine("Il file non esiste.");
        }
    }
}
