using System;

namespace PatternEDatabase.Bridge;

public abstract class RemoteControl
{
    private readonly IDevice _device;

    protected RemoteControl(IDevice device)
    {
        _device = device;
    }

    public virtual void TogglePower()
    {
        _device.TogglePower();
        Console.WriteLine($"{_device.Name}: accensione {(_device.IsOn ? "ON" : "OFF")}");
    }

    public virtual void VolumeUp()
    {
        _device.SetVolume(_device.Volume + 1);
        Console.WriteLine($"{_device.Name}: volume a {_device.Volume}");
    }

    public virtual void VolumeDown()
    {
        _device.SetVolume(_device.Volume - 1);
        Console.WriteLine($"{_device.Name}: volume a {_device.Volume}");
    }
}
