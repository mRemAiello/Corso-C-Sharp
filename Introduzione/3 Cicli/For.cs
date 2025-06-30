public class For
{
    public void Execute()
    {
        string colore_singolo = "Rosso";
        Console.WriteLine(colore_singolo);
        colore_singolo = "Viola";

        // 0 -> Rosso, 1 -> Verde, 2 -> Blu
        string[] colori = ["Rosso", "Verde", "Blu"];
        // 0 posizione
        // colori[0] -> Rosso
        colori[0] = "Viola";

        // Foreach
        // colore = "Viola"
        // Console.WriteLine(colore);
        // colore = "Verde"
        // Console.WriteLine(colore);
        // colore = "Blu"
        // Console.WriteLine(colore);
        foreach (string colore in colori)
        {
            Console.WriteLine(colore);
        }

        // For semplice con array
        // int i = 0;
        // i < colori.Length => 0 < 3
        // Console.WriteLine(colori[0]);
        // i++; => i = 1
        // i < colori.Length => 1 < 3
        // Console.WriteLine(colori[1]);
        // i++ => i = 2
        // i < colori.Length => 2 < 3
        // Console.WriteLine(colori[2]);
        // i++ => i = 3
        // i < colori.Length => 3 < 3 (false)
        for (int i = 0; i < colori.Length; i++)
        {
            Console.WriteLine(colori[i]);
        }

        // For con 2 variabili
        // i = 0 - j = 0, 1, 2
        // i = 1 - j = 0, 1, 2
        // i = 2 - j = 0, 1, 2

        // Esempio di matrice 3x3
        // Array 1 -> 0, 1, 2
        // Array 2 -> 3, 4, 1
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("i: " + i + ", j: " + j);
            }
        }
    }
}