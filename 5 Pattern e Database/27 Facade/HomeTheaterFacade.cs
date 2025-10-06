using System;

namespace PatternEDatabase.Facade;

public class HomeTheaterFacade
{
    private readonly StreamingService _streamingService;
    private readonly SurroundSoundSystem _soundSystem;
    private readonly Projector _projector;
    private readonly AmbientLight _ambientLight;

    public HomeTheaterFacade(
        StreamingService streamingService,
        SurroundSoundSystem soundSystem,
        Projector projector,
        AmbientLight ambientLight)
    {
        _streamingService = streamingService;
        _soundSystem = soundSystem;
        _projector = projector;
        _ambientLight = ambientLight;
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
}
