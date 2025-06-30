public class ContinueBreak
{
    public void Execute()
    {
        // Break for
        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                break;
            }
            Console.WriteLine("Iterazione: " + i);
        }

        // Break while
        int contatore = 0;
        while (contatore < 5)
        {
            if (contatore == 2)
            {
                break;
            }
            Console.WriteLine("Iterazione: " + contatore);
            contatore++;
        }

        // Continue, il ciclo fa il WriteLine delle i pari ma anche multiple di 3
        for (int i = 0; i < 20; i++)
        {
            // Metodo 1:
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine("Iterazione: " + i);
            }           

            // Metodo 2:
            if (i % 2 != 0)
                continue;

            if (i % 3 == 0)
                continue;

            Console.WriteLine("Iterazione: " + i);
        }

        // Continue while
        contatore = 0;
        while (contatore < 5)
        {
            if (contatore == 3)
            {
                contatore++;
                continue;
            }
            Console.WriteLine("Iterazione: " + contatore);
            contatore++;
        }
    }
}