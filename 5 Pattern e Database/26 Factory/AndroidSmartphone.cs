namespace PatternEDatabase.Factory;

public sealed class AndroidSmartphone : ISmartphone
{
    public string Name => "Pixel Ultra";

    public string Call(string contactName)
    {
        return $"{Name} avvia una chiamata Google Meet con {contactName}.";
    }
}
