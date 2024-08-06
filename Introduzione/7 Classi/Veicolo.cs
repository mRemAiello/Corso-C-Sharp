public class Veicolo
{
    private string _marca = "Non definito";
    private string _modello = "Non definito";
    private int _anno = 0;

    public Veicolo(string marca, string modello, int anno)
    {
        _marca = marca;
        _modello = modello;
        _anno = anno;

        // Qualora ci sia ambiguità sui nomi, usa this
        // this._anno = anno;
    }

    public Veicolo()
    {
    }

    public string GetMarca()
    {
        return _marca;
    }

    public void SetMarca(string marca)
    {
        _marca = marca;
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