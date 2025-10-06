using System;

namespace PatternEDatabase.Facade;

public class SurroundSoundSystem
{
    public void TurnOn()
    {
        Console.WriteLine("- Impianto surround acceso");
    }

    public void TurnOff()
    {
        Console.WriteLine("- Impianto surround spento");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"- Volume impostato a {level}");
    }
}
