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
        // Condizione 1: Importo > Saldo
        // Condizione 2: Problemi vari con l'ATM (offline, guasto, banca non disponibile, banca chiusa, non ha le monete)
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

    //
    // ContoBancario conto = new ContoBancario(500);
    // try
    // conto.Preleva(100);
    // catch (SaldoInsufficienteException ex)
}