public class SaldoInsufficienteException : Exception
{
    public SaldoInsufficienteException(string messaggio) : base(messaggio) { }
}

public class ContoBancario
{
    public decimal Saldo { get; private set; }

    public void Preleva(decimal importo)
    {
        if (importo > Saldo)
        {
            throw new SaldoInsufficienteException("Saldo insufficiente per completare l'operazione.");
        }
        Saldo -= importo;
    }
}