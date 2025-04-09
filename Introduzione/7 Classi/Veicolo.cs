public class Veicolo
{
    private string _marca = "";
    private string _modello = "";
    private int _annoDiProduzione = 0;
    private int _anzianita = 0;

    public Veicolo(string marca, string modello, int anno)
    {
        _marca = marca;
        _modello = modello;
        _annoDiProduzione = anno;
        _anzianita = 2025 - anno;

        // Qualora ci sia ambiguità sui nomi, usa this
        // this._anno = anno;
    }

    public Veicolo()
    {
        _marca = "Non definito";
        _modello = "Non definito";
        _annoDiProduzione = 0;
    }

    public string GetMarca()
    {
        return _marca;
    }

    public void SetMarca(string marca)
    {
        // 
        _marca = marca;
    }

    public void Avvia()
    {
        string str = "{} {} avviato";
        Console.WriteLine(string.Format(str, GetModello(), GetMarca()));
    }

    public string GetModello()
    {
        return _modello;
    }

    public void Arresta()
    {
        string str = "{} {} arrestato";
        Console.WriteLine(string.Format(str, GetModello(), GetMarca()));
    }

    public virtual void MostraInformazioni()
    {
        string stringa = "Marca: {}, Modello: {}, Anno: {}";
        Console.WriteLine(string.Format(stringa, _marca, _modello, _annoDiProduzione));
    }
}