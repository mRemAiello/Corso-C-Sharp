public class Program
{
    static void Main(string[] args)
    {
        ContoBancario conto = new(100);
        float cifra = 200;

        try
        {
            conto.Preleva(cifra);
        }
        catch (SaldoInsufficienteException ex)
        {
            Console.WriteLine(ex.Message);

            //
            cifra = conto.Saldo;
            conto.Preleva(cifra);
        }
        finally
        {
            Console.WriteLine("Operazione eseguita");
        }

        Console.WriteLine(conto.Saldo);
        Console.WriteLine("Avanti");
    }
}