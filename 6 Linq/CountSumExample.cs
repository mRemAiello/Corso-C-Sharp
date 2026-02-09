namespace LinqExamples;

public static class CountSumExample
{
    public static void Execute()
    {
        List<int> numeri = new() { 4, 7, 2, 9, 12, 5, 8 };

        int numeriPari = numeri.Count(n => n % 2 == 0);
        //int sommaTotale = numeri.Sum(n => n % 2 == 0);

        Console.WriteLine($"Count - Numero di valori pari: {numeriPari}");
        //Console.WriteLine($"Sum - Somma di tutti i valori: {sommaTotale}");
        Console.WriteLine();
    }
}
