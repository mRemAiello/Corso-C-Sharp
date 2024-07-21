public class Func
{
    void Print(string testo)
    {
        Console.WriteLine(testo);
    }

    // Metodo che calcola la somma di due numeri interi
    int Somma(int a, int b)
    {
        int risultato = a + b;
        return risultato;
    }

    public void Execute()
    {
        int x = 5;
        int y = 3;

        int risultato = Somma(x, y);

        string nome = "Mirko";
        Print(nome);
    }
}