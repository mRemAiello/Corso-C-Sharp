using System;

namespace PatternEDatabase.Facade;

public class AmbientLight
{
    public void Dim(int level)
    {
        Console.WriteLine($"- Luci ambientali regolate al {level}%");
    }

    public void TurnOn()
    {
        Console.WriteLine("- Luci ambientali accese soffusamente");
    }

    public void TurnOff()
    {
        Console.WriteLine("- Luci ambientali spente");
    }
}
