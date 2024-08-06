public class Program
{
    static void Main(string[] args)
    {
        Veicolo auto = new Veicolo("Ford", "Fiesta", 2000);

        var marca = auto.GetMarca();

        auto.MostraInformazioni();
    }
}