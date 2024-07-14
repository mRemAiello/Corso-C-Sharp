public class ContinueBreak
{
    public void Execute()
    {
        // Break for
        for (int i = 0; i < 5; i++)
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

        // Continue
        for (int i = 0; i < 5; i++)
        {
            if (i == 2)
            {
                continue;
            }
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