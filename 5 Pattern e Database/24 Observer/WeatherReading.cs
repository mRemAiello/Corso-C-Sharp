namespace PatternEDatabase.Observer;

/// <summary>
/// Rappresenta un singolo rilievo ambientale della stazione meteo.
/// </summary>
/// <param name="TemperatureCelsius">Temperatura in gradi centigradi.</param>
/// <param name="HumidityPercentage">Percentuale di umidità relativa.</param>
/// <param name="PressureHpa">Pressione atmosferica in hPa.</param>
public readonly record struct WeatherReading(decimal TemperatureCelsius, int HumidityPercentage, decimal PressureHpa);
