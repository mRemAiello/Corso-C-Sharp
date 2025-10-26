using System;

namespace PatternEDatabase.Bridge;

public static class BridgePatternDemo
{
    public static void Run()
    {
        Console.WriteLine("Esempio Bridge: separiamo telecomandi e dispositivi.\n");

        var tv = new Television();
        var radio = new Radio();

        RemoteControl basicRemote = new BasicRemote(tv);
        var advancedRemote = new AdvancedRemote(radio);

        Console.WriteLine("Uso del telecomando base con la TV:");
        basicRemote.TogglePower();
        basicRemote.VolumeUp();
        basicRemote.VolumeUp();
        basicRemote.VolumeDown();
        Console.WriteLine();

        Console.WriteLine("Uso del telecomando avanzato con la radio:");
        advancedRemote.TogglePower();
        advancedRemote.VolumeUp();
        advancedRemote.Mute();
        advancedRemote.TogglePower();

        Console.WriteLine("\nGrazie al Bridge possiamo combinare liberamente telecomandi e dispositivi.");
    }
}
