public class SaldoInsufficienteException : Exception
{
    public SaldoInsufficienteException(string messaggio) : base(messaggio) { }
}

public class ContoBancario
{
    public float Saldo { get; private set; }

    public ContoBancario(float saldo)
    {
        Saldo = saldo;
    }

    public void Preleva(float importo)
    {
        if (importo > Saldo)
        {
            throw new SaldoInsufficienteException("Saldo insufficiente per completare l'operazione.");
        }
        
        // 
        Saldo -= importo;
        Console.WriteLine("Prelevato " + importo + " $");
    }
}