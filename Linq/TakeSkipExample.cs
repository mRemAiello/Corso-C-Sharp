public static class TakeSkipExample
{
    public static void Execute()
    {
        List<int> numeri = Enumerable.Range(1, 10).ToList();

        IEnumerable<int> primiQuattro = numeri.Take(4);
        IEnumerable<int> senzaPrimiTre = numeri.Skip(3);
        IEnumerable<int> intervalloCentrale = numeri.Skip(2).Take(5);

        Console.WriteLine("Take - Primi 4 numeri: " + string.Join(", ", primiQuattro));
        Console.WriteLine("Skip - Numeri senza i primi 3: " + string.Join(", ", senzaPrimiTre));
        Console.WriteLine("Combinazione Skip/Take - Dal 3° al 7° numero: " + string.Join(", ", intervalloCentrale));
        Console.WriteLine();
    }
}
