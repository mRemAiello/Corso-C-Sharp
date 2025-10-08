public abstract class BankAccount
{
    private float _currentMoney = 0;

    //
    public float Money
    {
        get => _currentMoney;
        protected set
        {
            _currentMoney = value;
        }
    }

    //
    public BankAccount(float money)
    {
        Deposit(money);
    }

    //
    public abstract bool Deposit(float value);
    public abstract bool Withdraw(float value);
    public abstract float CalculateInterest();
}