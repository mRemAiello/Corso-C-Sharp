using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternEDatabase.Observer;

/// <summary>
/// Osservatore che accumula le letture e produce un report riassuntivo.
/// </summary>
public sealed class StatisticsWeatherObserver : IWeatherObserver
{
    private readonly List<WeatherReading> _readings = new();

    public void Update(WeatherReading reading)
    {
        _readings.Add(reading);
    }

    public string BuildReport()
    {
        if (_readings.Count == 0)
        {
            return "Statistiche non disponibili: nessun dato ricevuto.";
        }

        var averageTemperature = _readings.Average(r => r.TemperatureCelsius);
        var minTemperature = _readings.Min(r => r.TemperatureCelsius);
        var maxTemperature = _readings.Max(r => r.TemperatureCelsius);
        var averageHumidity = _readings.Average(r => r.HumidityPercentage);
        var lastPressure = _readings[^1].PressureHpa;

        var builder = new StringBuilder();
        builder.AppendLine("Statistiche della stazione meteo:");
        builder.AppendLine($" - Temperatura media: {averageTemperature:F1} °C (min {minTemperature:F1} °C, max {maxTemperature:F1} °C)");
        builder.AppendLine($" - Umidità media: {averageHumidity:F0}%");
        builder.Append($" - Ultima pressione rilevata: {lastPressure:F1} hPa");

        return builder.ToString();
    }
}
