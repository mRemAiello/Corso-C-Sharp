public class Confronto
{
    public void Execute()
    {
        int numero1 = 10;
        int numero2 = 20;

        bool uguale = numero1 == numero2; // false
        bool diverso = numero1 != numero2; // true
        bool minore = numero1 < numero2; // true
        bool maggiore = numero1 > numero2; // false
        bool minoreUguale = numero1 <= numero2; // true
        bool maggioreUguale = numero1 >= numero2; // false

        Console.WriteLine("Uguale: " + uguale); // Uguale: False
        Console.WriteLine("Diverso: " + diverso); // Diverso: True
        Console.WriteLine("Minore: " + minore); // Minore: True
        Console.WriteLine("Maggiore: " + maggiore); // Maggiore: False
        Console.WriteLine("Minore o Uguale: " + minoreUguale); // Minore o Uguale: True
        Console.WriteLine("Maggiore o Uguale: " + maggioreUguale); // Maggiore o Uguale: False
    }
}