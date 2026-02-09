public class Test
{
    public void Execute()
    {
        Acqua acqua = new Acqua();
        Vino vino = new Vino();

        BottigliaLiquido bottiglia0 = new BottigliaLiquido(acqua);

        Vino vino2 = (Vino)bottiglia0.GetLiquido();

        if (bottiglia0.GetLiquido() is Vino vinoTmp)
        {
            vinoTmp.ProprietaVino = 20;
        }

        // Card abstract -> SpellCard, CreatureCard, HeroCard, QuestCard
        // Card[] -> 1xSpellCard, 2xCreatureCard, 1xHeroCard...

        Contenitore<Acqua> bottiglia = new(acqua);
        Contenitore<Vino> bottiglia2 = new(vino);

        List<int> numeri = new List<int>();
        List<Persona> persone = new List<Persona>();


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