public class Giostra
{
    public void Execute()
    {
        int eta = 14;
        double altezza = 1.40;
        Console.WriteLine("Età: " + eta + ", Altezza: " + altezza);

        if (eta >= 18)
        {
            Console.WriteLine("Puoi salire sulla giostra senza restrizioni");
        }
        else if (altezza >= 1.50)
        {
            Console.WriteLine("Puoi salire sulla giostra accompagnato da un adulto");
        }
        else
        {
            Console.WriteLine("Non puoi salire sulla giostra, sei troppo basso");
        }
    }
}
