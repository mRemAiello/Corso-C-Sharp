namespace ProgrammazioneOggettiApp;

// record (record class) è un tipo riferimento, come una classe.
// Genera l'uguaglianza basata sui valori e la sintassi "with".
public record Persona(string Nome, int Eta);

// Una classe è un tipo riferimento: assegnarla copia il riferimento,
// quindi due variabili possono indicare lo stesso oggetto.
// Per impostazione predefinita, due istanze diverse non sono uguali con ==.
public class PersonaClasse
{
    public string Nome { get; set; } = "";
    public int Eta { get; set; }
}

// Una struct è un tipo valore: assegnarla copia i suoi dati.
// Equals confronta i valori dei campi; l'operatore == non è generato automaticamente.
public struct PersonaStruct
{
    public string Nome { get; set; }
    public int Eta { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is PersonaStruct other)
        {
            return Nome == other.Nome && Eta == other.Eta;
        }
        return false;
    }

    public override int GetHashCode() => base.GetHashCode();
}

// Un record struct è un tipo valore come una struct,
// ma genera uguaglianza basata sui valori e la sintassi "with".
public record struct PersonaRecordStruct(string Nome, int Eta);

public static class EsempioRecord
{
    public static void Mostra()
    {
        var persona = new Persona("Luca", 30);
        var stessaPersona = new Persona("Luca", 30);

        Console.WriteLine(persona);
        Console.WriteLine($"I record hanno uguaglianza basata sui valori: {persona == stessaPersona}");

        var personaAggiornata = persona with { Eta = 31 };
        Console.WriteLine($"Persona aggiornata: {personaAggiornata}");
        Console.WriteLine($"Persona originale: {persona}");

        var classe1 = new PersonaClasse { Nome = "Luca", Eta = 30 };
        var classe2 = new PersonaClasse { Nome = "Luca", Eta = 30 };
        Console.WriteLine($"Due classi con gli stessi dati sono la stessa istanza: {classe1 == classe2}");

        var struct1 = new PersonaStruct { Nome = "Luca", Eta = 30 };
        var struct2 = new PersonaStruct { Nome = "Luca", Eta = 30 };
        Console.WriteLine($"Due struct con gli stessi dati sono uguali: {struct1.Equals(struct2)}");

        var recordStruct1 = new PersonaRecordStruct("Luca", 30);
        var recordStruct2 = new PersonaRecordStruct("Luca", 30);
        Console.WriteLine($"Due record struct con gli stessi dati sono uguali: {recordStruct1 == recordStruct2}");
    }
}
