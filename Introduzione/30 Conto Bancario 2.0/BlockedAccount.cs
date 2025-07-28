public class BlockedAccount : BasicAccount
{
    public BlockedAccount(float money) : base(money)
    {
    }

    public override bool Withdraw(float value) => false;
}