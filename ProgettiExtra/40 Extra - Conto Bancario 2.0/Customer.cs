public class Customer
{
    private BankAccount[] _accounts;

    public Customer(BankAccount[] accounts)
    {
        _accounts = accounts;
    }

    public void ShowBalance()
    {
        foreach (BankAccount account in _accounts)
        {
            Console.WriteLine($"Saldo: {account.Money}, Interessi: {account.CalculateInterest()}");
        }
    }

    public void Deposit(int id, float value)
    {
        if (_accounts[id].Deposit(value))
        {
            Console.WriteLine("Operazione di deposito eseguita correttamente");
        }
    }

    public void Withdraw(int id, float value)
    {
        if (_accounts[id].Withdraw(value))
        {
            Console.WriteLine("Operazione di deposito eseguita correttamente");
        }
    }
}