// # Creare una classe Animale che abbia gli attributi “nome” e “specie”.
// # Aggiungi un metodo “emetti_suono” che stampi un suono specifico per ogni specie.
// # Ad esempio, se l’animale è un gatto dovrebbe stampare “Miao!”, se è un cane “Bau!”.

public class Animale4
{
    public string? nome = "";
    public string? specie = "";

    public Animale4(string? nome, string? specie)
    {
        this.nome = nome;
        this.specie = specie;
    }

    public void EmettiVerso()
    {
        if (specie == null)
        {
            Console.WriteLine("La specie non è stata impostata");
            return;
        }

        if (specie.Equals("cane"))
        {
            Console.WriteLine("Bau");
        }
        else if (specie.Equals("gatto"))
        {
            Console.WriteLine("Miao");
        }
        else
        {
            Console.WriteLine("Animale sconosciuto");
        }
    }
}