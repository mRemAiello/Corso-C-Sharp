namespace PatternEDatabase.Bridge;

public interface IDevice
{
    string Name { get; }
    bool IsOn { get; }
    int Volume { get; }

    void TogglePower();
    void SetVolume(int level);
}