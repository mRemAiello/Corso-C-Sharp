public class Veicolo
{
    private string _marca;
    private string _modello;
    private int _anno;

    public Veicolo(string nome, string modello, int anno)
    {
        _marca = nome;
        _modello = modello;
        _anno = anno;
    }

    public virtual void Avvia()
    {
        Console.WriteLine("Veicolo avviato.");
    }

    public void MostraInformazioni() 
    {
        string stringa = "Marca: {}, Modello: {}, Anno: {}";
        Console.WriteLine(string.Format(stringa, _marca, _modello, _anno));
    }
}