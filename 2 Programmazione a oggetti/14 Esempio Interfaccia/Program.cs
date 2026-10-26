public class Program
{
    public static void Main()
    {
        // Quale auto vuoi creare? (0: Benzina, 1 Diesel, 2 Ibrida)
        // Chiedo marca, modello, anno

        IBenzina benzina = new AutoBenzina
        {
            Marca = "Fiat",
            Modello = "Punto",
            Anno = 2022,
            Serbatoio = 40
        };

        AutoIbrida auto = new AutoIbrida
        {
            Marca = "Tesla",
            Modello = "Model S",
            Anno = 2024,
            Autonomia = 500,
            Serbatoio = 50
        };

        AutoBenzina autoBenzina = new AutoBenzina
        {
            Marca = "Fiat",
            Modello = "Punto",
            Anno = 2022,
            Serbatoio = 40
        };

        Vendi(benzina);
        Vendi(auto);
        Vendi(autoBenzina);
    }

    public static void Vendi(IBenzina auto)
    {
        // Vendita
    }
}