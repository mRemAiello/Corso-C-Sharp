using System;

namespace PatternEDatabase.Bridge;

public class AdvancedRemote : RemoteControl
{
    private readonly IDevice _device;

    public AdvancedRemote(IDevice device) : base(device)
    {
        _device = device;
    }

    public void Mute()
    {
        _device.SetVolume(0);
        Console.WriteLine($"{_device.Name}: muto attivato");
    }
}
