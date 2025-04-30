public class Test
{
    public void Execute()
    {
        Acqua acqua = new Acqua();
        Vino vino = new Vino();

        Contenitore<Acqua> bottiglia = new Contenitore<Acqua>(acqua);
        Contenitore<Vino> bottiglia2 = new Contenitore<Vino>(vino);


        /*
        */

        /*Contenitore<int> contenitoreInt = new(4);
        contenitoreInt.Aggiungi(5);
        Console.WriteLine(contenitoreInt.Contenuto); // Output: 5

        Contenitore<string> contenitoreStringa = new Contenitore<string>("");
        contenitoreStringa.Aggiungi("Ciao");
        Console.WriteLine(contenitoreStringa.Contenuto); // Output: Ciao*/
    }
}