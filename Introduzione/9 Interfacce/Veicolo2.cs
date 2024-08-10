public class Veicolo2 : IVeicolo
{
    private string _marca;
    private string _modello;
    
    public Veicolo2(string marca, string modello)
    {
        _marca = marca;
        _modello = modello;
    }

    public string GetMarca()
    {
        return _marca;
    }

    public string GetModello()
    {
        return _modello;
    }

    public void Avvia()
    {
        string str = "{} {} avviato";
        Console.WriteLine(string.Format(str, GetModello(), GetMarca()));
    }

    public void Arresta()
    {
        string str = "{} {} arrestato";
        Console.WriteLine(string.Format(str, GetModello(), GetMarca()));
    }
}
