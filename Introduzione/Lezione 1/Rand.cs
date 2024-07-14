public class Rand
{
    public void Execute()
    {
        // 
        var rand = new Random();
        long numeroRand = rand.NextInt64(1, 10);
        Console.WriteLine("Numero casuale: " + numeroRand);

        // Casting implicito
        int valoreIntero = 5;
        double valoreDoppio = valoreIntero; // Conversione implicita
        Console.WriteLine(valoreDoppio);

        // Casting esplicito
        double numeroVirgolaMobile = 3.14;
        int numeroIntero = (int)numeroVirgolaMobile; // Conversione esplicita
        Console.WriteLine(numeroIntero);
    }
}