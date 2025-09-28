public class SaldoInsufficienteException : Exception
{
    public SaldoInsufficienteException(string messaggio) : base(messaggio) { }
}

public class LimiteDepositoRaggiuntoException : Exception
{
    public LimiteDepositoRaggiuntoException(string messaggio) : base(messaggio) { }
}

public class ContoBancario
{
    public float Saldo { get; private set; }

    public ContoBancario(float saldo)
    {
        Saldo = saldo;
    }

    public bool VerificaSaldo()
    {
        return Saldo > 0;
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

    public void Deposita(float importo)
    {
        if (importo > 1000)
        {
            throw new LimiteDepositoRaggiuntoException("Limite di deposito giornaliero superato.");
        }

        Saldo += importo;
        Console.WriteLine("Depositato " + importo + " $");
    }
}