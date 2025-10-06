namespace PatternEDatabase.Factory;

public sealed class AndroidDeviceFactory : IDeviceFactory
{
    public ISmartphone CreateSmartphone() => new AndroidSmartphone();

    public ITablet CreateTablet() => new AndroidTablet();
}
