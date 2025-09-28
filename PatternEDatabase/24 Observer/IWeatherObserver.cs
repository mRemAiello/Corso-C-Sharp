namespace PatternEDatabase.Observer;

/// <summary>
/// Contratto per gli oggetti che vogliono ricevere aggiornamenti dalla stazione meteo.
/// </summary>
public interface IWeatherObserver
{
    void Update(WeatherReading reading);
}
