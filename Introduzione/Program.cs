using DelegateExample;
using EventExample;
using System;
using System.Data.SQLite;


class Program
{
    static void Main()
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
            
            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Tabella 'Students' creata con successo.");
        }

         // Collegamento al database School.db
        using (var connection = new SQLiteConnection("Data Source=School.db;Version=3;"))
        {
            connection.Open();

            // Query per inserire dati nella tabella Students
            string insertQuery = "INSERT INTO Students (FirstName, LastName, Age) VALUES (@FirstName, @LastName, @Age)";
            
            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                // Primo record: Anna Bianchi, 20 anni
                command.Parameters.AddWithValue("@FirstName", "Anna");
                command.Parameters.AddWithValue("@LastName", "Bianchi");
                command.Parameters.AddWithValue("@Age", 20);
                command.ExecuteNonQuery();

                // Secondo record: Luca Rossi, 22 anni
                command.Parameters.AddWithValue("@FirstName", "Luca");
                command.Parameters.AddWithValue("@LastName", "Rossi");
                command.Parameters.AddWithValue("@Age", 22);
                command.ExecuteNonQuery();

                // Terzo record: Marco Verdi, 21 anni
                command.Parameters.AddWithValue("@FirstName", "Marco");
                command.Parameters.AddWithValue("@LastName", "Verdi");
                command.Parameters.AddWithValue("@Age", 21);
                command.ExecuteNonQuery();
            }

            Console.WriteLine("3 record inseriti con successo nella tabella 'Students'.");
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