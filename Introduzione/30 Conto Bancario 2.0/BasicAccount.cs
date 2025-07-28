public class BasicAccount : BankAccount
{
    public BasicAccount(float money) : base(money)
    {
    }

    public override bool Deposit(float value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Value non può essere negativo o nullo");
            return false;
        }

        //
        Money += value;
        return true;
    }

    public override bool Withdraw(float value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Value non può essere negativo o nullo");
            return false;
        }

        //
        if (Money < value)
        {
            Console.WriteLine("Non hai abbastanza soldi da prelevare");
            return false;
        }

        //
        Money -= value;
        return true;
    }

    //
    public override float CalculateInterest() => 0;
}