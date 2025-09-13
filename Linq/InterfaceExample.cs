public interface IStudente
{
    string Nome { get; }
    int Voto { get; }
}

public class Studente : IStudente
{
    public string Nome { get; }
    public int Voto { get; }

    public Studente(string nome, int voto)
    {
        Nome = nome;
        Voto = voto;
    }
}

public static class InterfaceExample
{
    public static void Execute()
    {
        List<IStudente> studenti = new()
        {
            new Studente("Mario", 30),
            new Studente("Luigi", 24),
            new Studente("Peach", 28)
        };

        var promossi = studenti
            .Where(s => s.Voto >= 26)
            .Select(s => s.Nome);

        Console.WriteLine("Studenti promossi: " + string.Join(", ", promossi));
    }
}
