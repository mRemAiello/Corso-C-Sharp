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
        Console.WriteLine(_marca + " " + _modello + " motore avviato");
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

    // Esempio Equals
    // stringa == stringa2 => 0x000002 == 0x000003
    // stringa.Equals(stringa2) => "ciao" == "ciao"
    // Veicolo veicolo1 = new Veicolo("Fiat", "Panda", 2020);
    // Veicolo veicolo2 = new Veicolo("Fiat", "Panda", 2020);
    // veicolo1 == veicolo2 => false
    // veicolo1.Equals(veicolo2) => true
    // veicolo1.Equals(persona) => false
    public override bool Equals(object? obj)
    {
        if (obj is Veicolo veicolo)
        {
            return _marca.Equals(veicolo._marca) && _modello.Equals(veicolo._modello);
        }
        return false;
    }

    public override int GetHashCode()
    {
        // Veicolo => "ABC1235XYZ"
        // Veicolo Fiat, Panda, 2020 => int
        return base.GetHashCode();
    }

    public override string ToString()
    {
        // Console.WriteLine(veicolo1);
        // veicolo1.MostraInformazioni();
        return $"Marca: {_marca}, Modello: {_modello}, Anno: {_annoDiProduzione}, Anzianità: {_anzianita}";
    }

    public virtual void MostraInformazioni()
    {
        string stringa = "Marca: {}, Modello: {}, Anno: {}";
        Console.WriteLine(string.Format(stringa, _marca, _modello, _annoDiProduzione));
    }
}