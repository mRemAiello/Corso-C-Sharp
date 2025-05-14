public class Rand
{
    public void Execute()
    {
        // Seed : 6520251421301254014
        var rand = new Random();
        long numeroRand = rand.NextInt64(1, 10);
        int numeroRand2 = (int)rand.NextInt64(1, 10);
        Console.WriteLine("Numero casuale: " + numeroRand);
        Console.WriteLine("Numero casuale: " + numeroRand2);

        // Casting implicito
        int valoreIntero = 5;
        double valoreDoppio = valoreIntero; // Conversione implicita
        Console.WriteLine(valoreDoppio);

        // Casting esplicito
        double numeroVirgolaMobile = 3.14;
        int numeroIntero = (int)numeroVirgolaMobile + (int)valoreDoppio; // Conversione esplicita
        Console.WriteLine(numeroIntero);

        // NO!
        // string numero = "34";
        // int numeroIntero2 = (int)numero;
        // int numero = 5;
        // string numeroStringa = (string)numero;
    }
}