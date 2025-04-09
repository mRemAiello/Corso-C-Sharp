public class Automobile : Veicolo
{
    private int _numeroPorte = 0;

    //
    // Automobile auto = new Automobile("Fiat", "Panda", 2020, 5);

    public Automobile(string nome, string modello, int anno, int numeroPorte) : base(nome, modello, anno)
    {
        _numeroPorte = numeroPorte;
    }

    // Automobile auto = new Automobile();
    // Automobile() -> Veicolo("Non definito", "Non definito", 0) -> _numeroPorte = 0;

    public Automobile() : base("Non definito", "Non definito", 0)
    {
        _numeroPorte = 0;
    }

    /*public override void Avvia()
    {
        // Qualora volessi avviare il metodo della superclasse
        // base.Avvia();

        //
        Console.WriteLine("Automobile avviata.");
    }*/

    public override void MostraInformazioni()
    {
        base.MostraInformazioni();
        Console.WriteLine($"Numero porte: {_numeroPorte}");
    }
}