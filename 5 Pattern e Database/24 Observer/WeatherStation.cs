using System;
using System.Collections.Generic;

namespace PatternEDatabase.Observer;

/// <summary>
/// Soggetto osservato: mantiene lo stato meteo ed avvisa tutti gli osservatori registrati.
/// </summary>
public sealed class WeatherStation
{
    private readonly List<IWeatherObserver> _observers = new();
    private WeatherReading? _lastReading;

    /// <summary>
    /// Registra un nuovo osservatore e restituisce un oggetto IDisposable per annullare l'iscrizione.
    /// </summary>
    public IDisposable Subscribe(IWeatherObserver observer)
    {
        ArgumentNullException.ThrowIfNull(observer);

        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);

            if (_lastReading is WeatherReading lastReading)
            {
                observer.Update(lastReading);
            }
        }

        return new Subscription(_observers, observer);
    }

    /// <summary>
    /// Aggiorna le letture e notifica gli osservatori.
    /// </summary>
    public void UpdateMeasurements(decimal temperatureCelsius, int humidityPercentage, decimal pressureHpa)
    {
        Publish(new WeatherReading(temperatureCelsius, humidityPercentage, pressureHpa));
    }

    /// <summary>
    /// Pubblica una lettura già costruita.
    /// </summary>
    public void Publish(WeatherReading reading)
    {
        _lastReading = reading;

        // Copiamo l'elenco per evitare problemi se un osservatore si disiscrive durante la notifica.
        foreach (var observer in _observers.ToArray())
        {
            observer.Update(reading);
        }
    }

    private sealed class Subscription : IDisposable
    {
        private readonly List<IWeatherObserver> _observers;
        private IWeatherObserver? _observer;

        public Subscription(List<IWeatherObserver> observers, IWeatherObserver observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer is { } existingObserver)
            {
                _observers.Remove(existingObserver);
                _observer = null;
            }
        }
    }
}
