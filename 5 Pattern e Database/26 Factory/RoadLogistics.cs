namespace PatternEDatabase.Factory;

public sealed class RoadLogistics : Logistics
{
    protected override ITransport CreateTransport() => new Truck();
}