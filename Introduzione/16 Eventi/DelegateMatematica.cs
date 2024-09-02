class DelegateMatematica
{
    // Definizione del delegato che accetta due numeri e restituisce un risultato
    public delegate int Operazione(int x, int y);

    /*static void Main()
    {
        // Assegnazione di metodi ai delegati
        Operazione addizione = Add;
        Operazione moltiplicazione = Moltiplica;

        // Esecuzione delle operazioni
        Console.WriteLine("Somma di 5 e 3: " + addizione(5, 3));
        Console.WriteLine("Moltiplicazione di 5 e 3: " + moltiplicazione(5, 3));
    }*/

    // Metodo per sommare due numeri
    static int Add(int x, int y)
    {
        return x + y;
    }

    // Metodo per moltiplicare due numeri
    static int Moltiplica(int x, int y)
    {
        return x * y;
    }
}