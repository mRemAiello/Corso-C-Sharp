namespace PatternEDatabase.Facade;

public class Projector : IProjector
{
    public void TurnOn()
    {
        Console.WriteLine("- Proiettore acceso");
    }

    public void TurnOff()
    {
        Console.WriteLine("- Proiettore spento");
    }

    public void SetInput(string input)
    {
        Console.WriteLine($"- Proiettore impostato su sorgente {input}");
    }
}
