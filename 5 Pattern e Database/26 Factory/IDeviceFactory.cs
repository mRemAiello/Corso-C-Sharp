namespace PatternEDatabase.Factory;

public interface IDeviceFactory
{
    ISmartphone CreateSmartphone();
    ITablet CreateTablet();
}
