using System;

namespace PatternEDatabase.Bridge;

public class Television : IDevice
{
    public string Name => "Televisore";
    public bool IsOn { get; private set; }
    public int Volume { get; private set; } = 10;

    public void TogglePower()
    {
        IsOn = !IsOn;
    }

    public void SetVolume(int level)
    {
        Volume = Math.Clamp(level, 0, 100);
    }
}
