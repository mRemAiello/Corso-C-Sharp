namespace PatternEDatabase.Factory;

public sealed class AndroidTablet : ITablet
{
    public string Name => "Galaxy Tab";

    public string WatchVideo(string videoTitle)
    {
        return $"{Name} riproduce '{videoTitle}' da YouTube.";
    }
}
