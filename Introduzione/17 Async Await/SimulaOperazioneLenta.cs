public class SimulaOperazioneLenta
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Operazione avviata...");
        
        // Simulazione di un'operazione che richiede tempo
        await OperazioneLenta();
        
        Console.WriteLine("Operazione completata.");
    }

    // Metodo asincrono che simula un'operazione lenta
    static async Task OperazioneLenta()
    {
        Console.WriteLine("Inizio operazione lenta...");
        await Task.Delay(3000); // Simula un'attesa di 3 secondi
        Console.WriteLine("Fine operazione lenta.");
    }
}