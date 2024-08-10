public class Lista
{
    public void Execute()
    {
        // Primo metodo di creazione
        List<string> nomi = ["Mario", "Luigi", "Peach"];

        // Secondo
        List<string> nomi2 = new List<string>();
        nomi.Add("Mario");
        nomi.Add("Luigi");
        nomi.Add("Peach");

        // Foreach
        foreach (string nome in nomi)
        {
            Console.WriteLine(nome);
        }
    }
}