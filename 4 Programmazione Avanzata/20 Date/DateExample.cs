using System;

class DateExample
{
    public void Execute()
    {
        // Creazione di un oggetto DateTime con data e ora specifiche
        DateTime dataSpecificata = new DateTime(2025, 10, 20, 14, 30, 0);
        Console.WriteLine("Data specificata: " + dataSpecificata);

        // Ottenere la data e ora correnti
        DateTime adesso = DateTime.Now;
        Console.WriteLine("Ora attuale: " + adesso);

        // Solo la data corrente (senza l'ora)
        DateTime oggi = DateTime.Today;
        Console.WriteLine("Data odierna: " + oggi.ToShortDateString());

        // Aggiungere giorni, mesi o anni
        DateTime fraUnaSettimana = adesso.AddDays(7);
        Console.WriteLine("Tra una settimana sarà: " + fraUnaSettimana);

        // Formattare la data in modo personalizzato
        string dataFormattata = adesso.ToString("dd/MM/yyyy HH:mm:ss");
        Console.WriteLine("Data formattata: " + dataFormattata);

        // Calcolare la differenza tra due date
        TimeSpan differenza = dataSpecificata - adesso;
        Console.WriteLine("Differenza in giorni: " + differenza.Days);
    }
}
