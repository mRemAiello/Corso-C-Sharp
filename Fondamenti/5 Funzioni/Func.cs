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
    int Somma(int a, int b = 0)
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
    // media = 2, pippo = 2 
    bool TryMedia(int[]? numeri, out float media)
    {
        media = 0;
        if (numeri == null || numeri.Length == 0)
        {
            return false;
        }

        media = Media(numeri);
        return true;
    }

    // float Media(float[])
    // float Media(int[], bool)

    float Media(float[] numeri)
    {
        if (numeri == null || numeri.Length == 0)
        {
            return 0;
        }

        float somma = 0;
        for (int i = 0; i < numeri.Length; i++)
        {
            somma += numeri[i];
        }

        somma /= numeri.Length;
        return somma;
    }

    float Media(int[]? numeri, bool excludeNegative = true)
    {
        if (numeri == null || numeri.Length == 0)
        {
            return 0;
        }

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
        int[] eta = { 10, 20, 30 };
        float risultato_media = Media(eta);

        // 
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