namespace LinqExamples;

public static class SelectTypedExample
{
    private record Studente(string Nome, string Cognome, int Crediti);

    private record StudenteReport(string NomeCompleto, int Crediti, bool InRegola);

    public static void Execute()
    {
        List<Studente> studenti = new()
        {
            new("Alice", "Bianchi", 150),
            new("Luca", "Verdi", 165),
            new("Sara", "Rossi", 120),
            new("Marco", "Neri", 180)
        };

        IEnumerable<StudenteReport> report = studenti
            .Select(s => new StudenteReport(
                NomeCompleto: $"{s.Nome} {s.Cognome}",
                Crediti: s.Crediti,
                InRegola: s.Crediti >= 150));

        Console.WriteLine("Select tipizzato - Stato dei crediti per studente:");
        foreach (StudenteReport r in report)
        {
            string stato = r.InRegola ? "in regola" : "da recuperare";
            Console.WriteLine($" - {r.NomeCompleto}: {r.Crediti} CFU ({stato})");
        }

        Console.WriteLine();
    }
}
