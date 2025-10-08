public class FileManager
{
    public FileManager(Observer observer)
    {
        observer.OnContattoAggiunto += SalvaContatti;
    }
    
    private void SalvaContatti(Contatto contatto)
    {
        // Logica per salvare i contatti su file
        Console.WriteLine($"Salvataggio contatto: {contatto} dalla classe FileManager funzione Salva");
    }
}