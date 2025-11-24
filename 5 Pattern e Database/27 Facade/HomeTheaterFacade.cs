namespace PatternEDatabase.Facade;

public class HomeTheaterFacade
{
    private readonly StreamingService _streamingService;
    private readonly SurroundSoundSystem _soundSystem;
    private readonly IProjector _projector;
    private readonly AmbientLight _ambientLight;

    public HomeTheaterFacade(IProjector projector)
    {
        _streamingService = new();
        _soundSystem = new();
        _projector = projector;
        _ambientLight = new();
    }

    public void StartMovieNight(string movieTitle)
    {
        Console.WriteLine($"Preparazione della serata cinema per '{movieTitle}'...");
        _ambientLight.Dim(20);
        _ambientLight.TurnOn();
        _projector.TurnOn();
        _projector.SetInput("HDMI1");
        _soundSystem.TurnOn();
        _soundSystem.SetVolume(25);
        _streamingService.Connect();
        _streamingService.Play(movieTitle);
        Console.WriteLine("Buona visione!\n");
    }

    public void EndMovieNight()
    {
        Console.WriteLine("Chiusura della serata cinema...");
        _streamingService.Disconnect();
        _soundSystem.TurnOff();
        _projector.TurnOff();
        _ambientLight.TurnOff();
        Console.WriteLine("Serata conclusa. A presto!\n");
    }

    public void Connect() => _streamingService.Connect();
    public void Disconnect() => _streamingService.Disconnect();
    public void TurnOnProjector() => _projector.TurnOn();
    public void TurnOffProjector() => _projector.TurnOff();
    public void TurnOnLights() => _ambientLight.TurnOn();
    public void TurnOffLights() => _ambientLight.TurnOff();
    public void SetDimLightsLevel(int level) => _ambientLight.Dim(level);
    public void TurnOnSoundSystem() => _soundSystem.TurnOn();
    public void TurnOffSoundSystem() => _soundSystem.TurnOff();
    public void SetSoundSystemVolume(int level) => _soundSystem.SetVolume(level);
    public void PlayStreamingMovie(string movie) => _streamingService.Play(movie);
    public void PlayMovie(string movie)
    {
        StartMovieNight(movie);
        EndMovieNight();
    }
}