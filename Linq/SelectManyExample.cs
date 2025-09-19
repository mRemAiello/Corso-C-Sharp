namespace LinqExamples;

public static class SelectManyExample
{
    private record Dipartimento(string Nome, List<string> Corsi);

    public static void Execute()
    {
        List<Dipartimento> dipartimenti = new()
        {
            new("Ingegneria", new List<string> { "Analisi 1", "Fisica 1", "Programmazione" }),
            new("Economia", new List<string> { "Microeconomia", "Macroeconomia" }),
            new("Lettere", new List<string> { "Letteratura italiana", "Storia contemporanea" })
        };

        IEnumerable<string> tuttiICorsi = dipartimenti
            .SelectMany(d => d.Corsi, (dipartimento, corso) => $"{dipartimento.Nome}: {corso}")
            .OrderBy(nomeCorso => nomeCorso);

        Console.WriteLine("SelectMany - Elenco completo dei corsi per dipartimento:");
        foreach (string corso in tuttiICorsi)
        {
            Console.WriteLine($" - {corso}");
        }

        Console.WriteLine();
    }
}
