public static class SetOperationsExample
{
    public static void Execute()
    {
        List<string> fruttaEstiva = new() { "Pesca", "Albicocca", "Ciliegia", "Anguria", "Pesca" };
        List<string> fruttaInvernale = new() { "Arancia", "Mela", "Pera", "Cachi", "Ciliegia" };

        IEnumerable<string> fruttaSenzaDuplicati = fruttaEstiva.Distinct();
        IEnumerable<string> fruttaDiTutteLeStagioni = fruttaEstiva.Union(fruttaInvernale);
        IEnumerable<string> fruttaInComune = fruttaEstiva.Intersect(fruttaInvernale);
        IEnumerable<string> soloEstiva = fruttaEstiva.Except(fruttaInvernale);

        Console.WriteLine("Distinct - Frutta estiva senza duplicati: " + string.Join(", ", fruttaSenzaDuplicati));
        Console.WriteLine("Union - Frutta disponibile in entrambe le stagioni: " + string.Join(", ", fruttaDiTutteLeStagioni));
        Console.WriteLine("Intersect - Frutta presente in entrambe le liste: " + string.Join(", ", fruttaInComune));
        Console.WriteLine("Except - Frutta solo estiva: " + string.Join(", ", soloEstiva));
        Console.WriteLine();
    }
}
