public static class AllAnyContainsExample
{
    public static void Execute()
    {
        List<int> voti = new() { 28, 30, 26, 29, 30 };

        bool tuttiPromossi = voti.All(v => v >= 18);
        bool qualcunoTrenta = voti.Any(v => v == 30);
        bool contieneVotoPerfetto = voti.Contains(30);

        Console.WriteLine($"All >= 18: {tuttiPromossi}");
        Console.WriteLine($"Any == 30: {qualcunoTrenta}");
        Console.WriteLine($"Contains 30: {contieneVotoPerfetto}");
        Console.WriteLine();
    }
}
