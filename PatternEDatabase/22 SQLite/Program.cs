using System;
using System.Data.SQLite;

namespace SQLiteExamples;

/*class Program
{
    static void Main()
    {
        var dbPath = "example.db";
        if (File.Exists(dbPath))
        {
            File.Delete(dbPath);
        }

        SQLiteConnection.CreateFile(dbPath);
        using var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
        connection.Open();

        using var create = new SQLiteCommand("CREATE TABLE people (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, age INTEGER)", connection);
        create.ExecuteNonQuery();

        using var insert = new SQLiteCommand("INSERT INTO people (name, age) VALUES (@name, @age)", connection);
        insert.Parameters.Add(new SQLiteParameter("@name"));
        insert.Parameters.Add(new SQLiteParameter("@age"));

        // "INSERT INTO people (name, age) VALUES (Alice, 30)"
        insert.Parameters["@name"].Value = "Alice";
        insert.Parameters["@age"].Value = 30;
        insert.ExecuteNonQuery();

        // "INSERT INTO people (name, age) VALUES (Bob, 25)"
        insert.Parameters["@name"].Value = "Bob";
        insert.Parameters["@age"].Value = 25;
        insert.ExecuteNonQuery();

        using var query = new SQLiteCommand("SELECT id, name, age FROM people", connection);
        using var reader = query.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"{reader["id"]}: {reader["name"]} ({reader["age"]})");
        }
    }
}*/
