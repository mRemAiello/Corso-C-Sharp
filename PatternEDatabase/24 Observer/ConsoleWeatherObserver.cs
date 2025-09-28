using System;

namespace PatternEDatabase.Observer;

/// <summary>
/// Osservatore concreto che stampa su console gli aggiornamenti ricevuti.
/// </summary>
public sealed class ConsoleWeatherObserver : IWeatherObserver
{
    private readonly string _name;

    public ConsoleWeatherObserver(string name)
    {
        _name = string.IsNullOrWhiteSpace(name) ? "Display" : name.Trim();
    }

    public void Update(WeatherReading reading)
    {
        Console.WriteLine($"[{_name}] Temperatura: {reading.TemperatureCelsius:F1} °C - Umidità: {reading.HumidityPercentage}% - Pressione: {reading.PressureHpa:F1} hPa");
    }
}
