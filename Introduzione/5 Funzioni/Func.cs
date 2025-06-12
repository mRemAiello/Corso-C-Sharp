public class Func
{
    void Print(string testo = "")
    {
        if (string.IsNullOrEmpty(testo))
        {
            return;
        }

        //
        Console.WriteLine(testo);
    }

    // Somma();
    // Somma(1);
    // Somma(1, 2);

    // Metodo che calcola la somma di due numeri interi
    int Somma(int a, int b)
    {
        int risultato = a + b;
        return risultato;
    }

    // Overloading (Stesso nome della funzione, parametri differenti)
    // Somma(float, float);
    // Somma(int, int);
    // Somma(20.5f); => Somma => a = 20.5, b = 0
    float Somma(float a = 0, float b = 0)
    {
        return a + b;
    }

    // numeri, i, somma
    bool TryMedia(int[] numeri, out float media)
    {
        media = 0;
        if (numeri.Length == 0)
        {
            return false;
        }

        media = Media(numeri);
        return true;
    }

    float Media(int[] numeri, bool excludeNegative = true)
    {
        int somma = 0;
        for (int i = 0; i < numeri.Length; i++)
        {
            somma += numeri[i];
        }

        somma /= numeri.Length;
        return somma;
    }

    public void Execute()
    {
        int x = 5;
        int y = 3;
        int a = 5;
        int b = 3;
        int risultato = Somma(a, b);
        float risultato2 = Somma((float)x, y);

        //
        int[] eta = { 20, 22, 21 };
        if (TryMedia(eta, out float pippo))
        {
            Console.WriteLine("Media: " + pippo);
        }


        //
        Console.WriteLine(risultato);
        Console.WriteLine(risultato2);

        //
        string nome = "Mirko";
        Print(nome);

        Print("");
    }
}