public class ParcoGiochi
{
    public void Execute()
    {
        double cash = 5.0;
        Console.WriteLine("Cash: " + cash);

        if (cash < 10.0)
        {
            Console.WriteLine("Non puoi entrare nel parco giochi");
        }
        else
        {
            Console.WriteLine("Puoi entrare nel parco giochi");
        }
    }
}
