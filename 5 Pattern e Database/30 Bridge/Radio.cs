using System;

namespace PatternEDatabase.Bridge;

public class Radio : IDevice
{
    public string Name => "Radio";
    public bool IsOn { get; private set; }
    public int Volume { get; private set; } = 5;

    public void TogglePower()
    {
        IsOn = !IsOn;
    }

    public void SetVolume(int level)
    {
        Volume = Math.Clamp(level, 0, 50);
    }
}
