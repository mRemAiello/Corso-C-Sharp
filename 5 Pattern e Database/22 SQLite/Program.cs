using System;
using System.Data.SQLite;
using System.IO;

namespace SQLiteExamples;

public static class SQLiteDemo
{
    public static void Run()
    {
        var tempFile = Path.Combine(Path.GetTempPath(), $"sqlite-demo-{Guid.NewGuid():N}.db");
        Console.WriteLine("=== SQLite Demo ===");
        Console.WriteLine($"Database temporaneo: {tempFile}");

        try
        {
            if (File.Exists(tempFile))
            {
                File.Delete(tempFile);
            }

            SQLiteConnection.CreateFile(tempFile);
            using var connection = new SQLiteConnection($"Data Source={tempFile};Version=3;");
            connection.Open();

            using var create = new SQLiteCommand(
                "CREATE TABLE people (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, age INTEGER)",
                connection);
            create.ExecuteNonQuery();

            // uso simile al format, diventa 
            // nella query INSERT INTO people (name, age) VALUES (@name, @age) 
            // andiamo a sostituire @name e @age con i valori reali
            using var insert = new SQLiteCommand(
                "INSERT INTO people (name, age) VALUES (@name, @age)",
                connection);
            insert.Parameters.Add(new SQLiteParameter("@name"));
            insert.Parameters.Add(new SQLiteParameter("@age"));

            insert.Parameters["@name"].Value = "Alice";
            insert.Parameters["@age"].Value = 30;
            insert.ExecuteNonQuery();

            insert.Parameters["@name"].Value = "Bob";
            insert.Parameters["@age"].Value = 25;
            insert.ExecuteNonQuery();

            using var query = new SQLiteCommand("SELECT id, name, age FROM people", connection);
            using var reader = query.ExecuteReader();
            // il contenuto di reader.Read()
            // reader["id"], reader["name"], reader["age"]
            while (reader.Read())
            {
                Console.WriteLine($"{reader["id"]}: {reader["name"]} ({reader["age"]})");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Si è verificato un errore durante l'esecuzione della demo SQLite.");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            try
            {
                if (File.Exists(tempFile))
                {
                    File.Delete(tempFile);
                }
            }
            catch (Exception cleanupEx)
            {
                Console.WriteLine("Impossibile eliminare il file temporaneo creato per la demo.");
                Console.WriteLine(cleanupEx.Message);
            }
        }
    }
}
