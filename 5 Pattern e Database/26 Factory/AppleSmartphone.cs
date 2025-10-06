namespace PatternEDatabase.Factory;

public sealed class AppleSmartphone : ISmartphone
{
    public string Name => "iPhone Pro";

    public string Call(string contactName)
    {
        return $"{Name} avvia una chiamata FaceTime con {contactName}.";
    }
}
