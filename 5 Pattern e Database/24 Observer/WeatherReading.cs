namespace PatternEDatabase.Observer;

/// <summary>
/// Rappresenta un singolo rilievo ambientale della stazione meteo.
/// </summary>
/// <param name="TemperatureCelsius">Temperatura in gradi centigradi.</param>
/// <param name="HumidityPercentage">Percentuale di umidità relativa.</param>
/// <param name="PressureHpa">Pressione atmosferica in hPa.</param>
public class WeatherReading
{
    public decimal TemperatureCelsius;
    public int HumidityPercentage;
    public decimal PressureHpa;

    public WeatherReading(decimal temperatureCelsius, int humidityPercentage, decimal pressureHpa)
    {
        TemperatureCelsius = temperatureCelsius;
        HumidityPercentage = humidityPercentage;
        PressureHpa = pressureHpa;
    }
}