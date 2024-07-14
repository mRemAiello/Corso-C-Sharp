public class For
{
    public void Execute()
    {
        string[] colori = { "Rosso", "Verde", "Blu" };

        foreach (string colore in colori)
        {
            Console.WriteLine(colore);
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("i: " + i + ", j: " + j);
            }
        }
    }
}