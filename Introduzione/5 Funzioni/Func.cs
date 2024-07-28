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

    // Metodo che calcola la somma di due numeri interi
    int Somma(int a, int b)
    {
        int risultato = a + b;
        return risultato;
    }

    // Overloading (Stesso nome della funzione, parametri differenti)
    float Somma(float a, float b)
    {
        return a + b;
    }

    public void Execute()
    {
        int x = 5;
        int y = 3;
        int risultato = Somma(x, y);
        float risultato2 = Somma((float)x, y);

        //
        Console.WriteLine(risultato);
        Console.WriteLine(risultato2);

        //
        string nome = "Mirko";
        Print(nome);

        Print("");
    }
}