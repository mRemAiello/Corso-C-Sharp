namespace PatternEDatabase.Factory;

public sealed class AppleTablet : ITablet
{
    public string Name => "iPad Air";

    public string WatchVideo(string videoTitle)
    {
        return $"{Name} riproduce '{videoTitle}' da Apple TV+.";
    }
}
