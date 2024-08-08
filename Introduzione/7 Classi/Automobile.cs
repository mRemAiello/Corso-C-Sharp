public class Automobile : Veicolo
{
    private int _numeroPorte = 0;

    public Automobile(string nome, string modello, int anno, int numeroPorte) : base(nome, modello, anno)
    {
        _numeroPorte = numeroPorte;
    }

    public Automobile() : base("", "", 0)
    {
        _numeroPorte = 0;
    }

    public override void Avvia()
    {
        // Qualora volessi avviare il metodo della superclasse
        // base.Avvia();

        //
        Console.WriteLine("Automobile avviata.");
    }

    public override void MostraInformazioni()
    {
    }
}