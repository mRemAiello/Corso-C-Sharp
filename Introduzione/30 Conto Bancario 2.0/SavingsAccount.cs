public class SavingsAccount : BasicAccount
{
    private float _interests;

    //
    public float Interests
    {
        get => _interests;
        protected set => _interests = value;
    }

    public SavingsAccount(float money, float interests) : base(money)
    {
        _interests = interests;
    }

    public override float CalculateInterest() => Money * _interests / 100;
}