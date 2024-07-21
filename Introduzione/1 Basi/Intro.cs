public class Intro
{
    public void Execute()
    {
        int etaDiMirko = 33;
        int mediaDeiVoti = 40;
        int numero = 20;
        int etaDiTizio = 10;

        // Tipi di variabili
        int x = 20;
        float t = 20.5f;
        string frase = "Ciao sono ";
        bool prova = true;
        prova = false;

        // Utilizzo di una variabile
        x = 10;
        int y = 20;
        int z = x + y;
        z = x - y;
        z = x * y;
        // Risultato della divisione
        z = x / y;
        // Resto della divisione
        z = x % y;


        // 
        Console.WriteLine("Resto della divisione: " + z);


        // Input
        Console.Write("Inserisci la tua età: ");
        string inputEta = Console.ReadLine();
        int eta = Convert.ToInt32(inputEta);
        Console.WriteLine("Hai " + eta + " anni.");
    }
}