using System;

public class DatabaseManager : GenericSingleton<DatabaseManager>
{
    private bool _isConnected;
    private bool _dataLoaded;

    protected override void OnPostAwake()
    {
        Console.WriteLine("[DatabaseManager] Istanza creata.");
    }

    protected override void OnPostDestroy()
    {
        Console.WriteLine("[DatabaseManager] Istanza distrutta.");
        _isConnected = false;
        _dataLoaded = false;
    }

    public void Connect()
    {
        if (_isConnected)
        {
            Console.WriteLine("[DatabaseManager] Connessione già attiva.");
            return;
        }

        Console.WriteLine("[DatabaseManager] Connessione al database...");
        _isConnected = true;
    }

    public void Load()
    {
        if (!_isConnected)
        {
            Console.WriteLine("[DatabaseManager] Impossibile caricare: nessuna connessione attiva.");
            return;
        }

        Console.WriteLine("[DatabaseManager] Caricamento dei dati completato.");
        _dataLoaded = true;
    }

    public void Save()
    {
        if (!_isConnected || !_dataLoaded)
        {
            Console.WriteLine("[DatabaseManager] Nulla da salvare: assicurarsi che la connessione sia attiva e i dati siano caricati.");
            return;
        }

        Console.WriteLine("[DatabaseManager] Salvataggio delle modifiche eseguito.");
    }
}
