
class Program
{
    static void Main(string[] args)
    {
        Veicolo veicolo = new Veicolo("Fiat", "Panda", 2020);
        veicolo.MostraInformazioni();
        veicolo.Avvia();
        veicolo.Arresta();

        Veicolo veicolo2 = new Veicolo("Ford", "Focus", 2018);
        veicolo2.MostraInformazioni();
        veicolo2.Avvia();
        veicolo2.Arresta();
    }
}

    /*static async Task Main(string[] args)
    {
        DatabaseManager.Instance.Connect();

        // Avvio di più operazioni asincrone in parallelo
        Task operazione1 = OperazioneAsincrona("Operazione 1", 2000);
        Task operazione2 = OperazioneAsincrona("Operazione 2", 3000);
        Task operazione3 = OperazioneAsincrona("Operazione 3", 1000);

        Console.WriteLine(operazione1.Status);
        Console.WriteLine(operazione2.Status);
        Console.WriteLine(operazione3.Status);

        // Attende il completamento di tutte le operazioni
        await Task.WhenAll(operazione1, operazione2, operazione3);

        Console.WriteLine("Tutte le operazioni sono completate.");
    }

    // Metodo asincrono che simula un'operazione con un'attesa variabile
    static async Task OperazioneAsincrona(string nomeOperazione, int delay)
    {
        Console.WriteLine($"{nomeOperazione} avviata.");
        await Task.Delay(delay);
        Console.WriteLine($"{nomeOperazione} completata.");
    }
}

    /*static void Main()
    {
        // Crea il database School.db
        using (var connection = new SQLiteConnection("Data Source=School.db;Version=3;"))
        {
            connection.Open();

            // Crea la tabella Students
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Students (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        FirstName TEXT NOT NULL,
                                        LastName TEXT NOT NULL,
                                        Age INTEGER NOT NULL)";
            
            int rows = 0;
            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                rows = command.ExecuteNonQuery();
            }

            Console.WriteLine("Tabella 'Students' creata con successo.");
            Console.WriteLine("Righe coinvolte: " + rows);
        }

        // Collegamento al database School.db
        using (var connection = new SQLiteConnection("Data Source=School.db;Version=3;"))
        {
            connection.Open();

            // Query per inserire dati nella tabella Students
            string insertQuery = "INSERT INTO Students (FirstName, LastName, Age) VALUES (@FirstName, @LastName, @Age)";

            int rows = 0;  
            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                // Primo record: Anna Bianchi, 20 anni
                command.Parameters.AddWithValue("@FirstName", "Anna");
                command.Parameters.AddWithValue("@LastName", "Bianchi");
                command.Parameters.AddWithValue("@Age", 20);
                rows += command.ExecuteNonQuery();

                // Secondo record: Luca Rossi, 22 anni
                command.Parameters.AddWithValue("@FirstName", "Luca");
                command.Parameters.AddWithValue("@LastName", "Rossi");
                command.Parameters.AddWithValue("@Age", 22);
                rows += command.ExecuteNonQuery();

                // Terzo record: Marco Verdi, 21 anni
                command.Parameters.AddWithValue("@FirstName", "Marco");
                command.Parameters.AddWithValue("@LastName", "Verdi");
                command.Parameters.AddWithValue("@Age", 21);
                rows += command.ExecuteNonQuery();
            }

            Console.WriteLine("3 record inseriti con successo nella tabella 'Students'.");
            Console.WriteLine("Righe coinvolte: " + rows);
        }
    }
}

    /*
    static void Main(string[] args)
    {
        Thermostat thermostat = new();

        // Iscrizione all'evento
        thermostat.ThresholdReached += HandleThresholdReached;

        // Aumento della temperatura
        thermostat.IncreaseTemperature(30);
        thermostat.IncreaseTemperature(40);

        // A questo punto l'evento verrà sollevato
        thermostat.IncreaseTemperature(50); 
    }

    // Metodo gestore dell'evento
    static void HandleThresholdReached(object sender, EventArgs e)
    {
        if (e is ThermostatEventArgs)
        {
            ThermostatEventArgs args = (ThermostatEventArgs)e;
            Console.WriteLine("Soglia di temperatura superata di " + args.SogliaDiSuperamento);
            Console.WriteLine("Temperatura attuale: " + args.TemperaturaCorrente);
        }

        if (sender is Thermostat)
        {
            // Eventuali funzioni da richiamare nella classe che lancia l'evento
            Thermostat thermostat = (Thermostat)sender;
        }
    }*/
//}