public class Automobile
{
    string marca;
    string modello;
    int anno;

    public Automobile(string m, string mod, int a)
    {
        marca = m;
        modello = mod;
        anno = a;
    }

    public Automobile(string m, int a)
    {
        marca = m;
        anno = a;
        modello = "Sconosciuto";
    }

    // Costruttore predefinito senza parametri
    public Automobile()
    {
        marca = "Sconosciuta";
        modello = "Sconosciuto";
        anno = 0;
    }

    public void MostraInformazioni() 
    {
        string stringa = "Marca: {}, Modello: {}, Anno: {}";
        Console.WriteLine(string.Format(stringa, marca, modello, anno));
    }
}