public class Program
{
    static void Main(string[] args)
    {
        Vettore3D vettore1 = new Vettore3D(1, 2, 3);
        Vettore3D vettore2 = new Vettore3D(3, 4, 5);

        Vettore3D vettore = vettore1 * vettore2;

        Console.WriteLine(vettore);
    }
}