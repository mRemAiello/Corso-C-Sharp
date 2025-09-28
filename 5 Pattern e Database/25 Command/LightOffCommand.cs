namespace PatternEDatabase.Command;

public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.Spegni();
    }

    public void Undo()
    {
        _light.Accendi();
    }
}
