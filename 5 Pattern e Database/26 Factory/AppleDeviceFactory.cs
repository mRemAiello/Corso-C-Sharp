namespace PatternEDatabase.Factory;

public sealed class AppleDeviceFactory : IDeviceFactory
{
    public ISmartphone CreateSmartphone() => new AppleSmartphone();

    public ITablet CreateTablet() => new AppleTablet();
}
