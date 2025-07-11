public class Intro
{
    public void Execute()
    {
        // Dichiarazione
        //int variabile = 0;
        // Inizializzazione
        // variabile = 10;
        // Dichiarazione e inizializzazione
        //int variabile2 = 20;

        // 0x000123834823 -> 40
        int etaDiMirko = 34;
        int mediaDeiVoti = 40;
        int numero = 20;
        int etaDiTizio = 10;

        //
        Console.WriteLine("Ciao sono Mirko e ho " + etaDiMirko + " anni.");
        Console.WriteLine("La media dei voti è " + mediaDeiVoti + ".");
        Console.WriteLine("Il numero è " + numero + ".");
        Console.WriteLine("Ciao sono Tizio e ho " + etaDiTizio + " anni.");

        // Tipi di variabili
        int x = 20;
        float t = 20.5f;
        double decimale = 200.4;
        string frase = "Ciao sono ";
        bool prova = true;
        prova = false;

        //
        Console.WriteLine("Il valore di x è " + x);
        Console.WriteLine("Il valore di t è " + t);
        Console.WriteLine("Il valore di frase è " + frase);
        Console.WriteLine("Il valore di prova è " + prova);


        // Utilizzo di una variabile
        x = 10;
        int y = 6;
        float z = x + y;
        Console.WriteLine("Il risultato è " + z);
        z = x - y;
        Console.WriteLine("Il risultato è " + z);
        z = x * y;
        Console.WriteLine("Il risultato è " + z);
        
        // Risultato della divisione
        z = x / y;
        Console.WriteLine("Il risultato è " + z);

        // Resto della divisione
        z = x % y;
        Console.WriteLine("Il risultato è " + z);


        // Input
        Console.Write("Inserisci la tua età: ");
        string? inputEta = Console.ReadLine();
        int eta = Convert.ToInt32(inputEta);
        Console.WriteLine("Hai " + eta + " anni.");
    }
}