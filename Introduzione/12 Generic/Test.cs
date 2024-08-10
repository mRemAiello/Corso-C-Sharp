public class Test
{
    public void Execute()
    {
        Contenitore<int> contenitoreInt = new Contenitore<int>();
        contenitoreInt.Aggiungi(5);
        Console.WriteLine(contenitoreInt.Ottieni()); // Output: 5

        Contenitore<string> contenitoreStringa = new Contenitore<string>();
        contenitoreStringa.Aggiungi("Ciao");
        Console.WriteLine(contenitoreStringa.Ottieni()); // Output: Ciao
    }
}