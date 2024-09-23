public class For
{
    public void Execute()
    {
        string colore_singolo = "Rosso";
        // 0 -> Rosso, 1 -> Verde, 2 -> Blu
        string[] colori = { "Rosso", "Verde", "Blu" };
        string[] colori_2 = new string[10];

        colori[0] = "Viola";

        // Foreach
        foreach (var colore in colori)
        {
            Console.WriteLine(colore);
        }

        // For semplice con array
        for (int i = 0; i < colori.Length; i++)
        {
            Console.WriteLine(colori[i]);
        }

        // For con 2 variabili
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("i: " + i + ", j: " + j);
            }
        }
    }
}