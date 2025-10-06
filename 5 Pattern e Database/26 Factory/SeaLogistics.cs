namespace PatternEDatabase.Factory;

public sealed class SeaLogistics : Logistics
{
    protected override ITransport CreateTransport() => new Ship();
}
