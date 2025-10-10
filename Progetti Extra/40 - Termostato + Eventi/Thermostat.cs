public class Thermostat
{
    private bool _status = false;
    private int _temperature;
    private int _minThreshold;
    private int _maxThreshold;

    // Definizione dell'evento
    public event ThermostatStatusEvent? OnThermostatStart;
    public event ThermostatStatusEvent? OnThermostatShutDown;
    public event ThresholdReachedEvent? OnMinThresholdReached;
    public event ThresholdReachedEvent? OnMaxThresholdReached;

    //
    public int Temperature => _temperature;
    public int MinThreshold => _minThreshold;
    public int MaxThreshold => _maxThreshold;

    // Costruttore
    public Thermostat(int startingTemperature, int maxThreshold, int minThreshold)
    {
        _temperature = startingTemperature;
        _minThreshold = minThreshold;
        _maxThreshold = maxThreshold;
        _status = false;
    }

    public void Start()
    {
        _status = true;
        OnThermostatStart?.Invoke(this, new ThermostatStatusEventsArgs() { Status = _status });
    }

    public void ShutDown()
    {
        _status = false;
        OnThermostatShutDown?.Invoke(this, new ThermostatStatusEventsArgs() { Status = _status });
    }

    public void IncreaseTemperature(int increment)
    {
        if (_status == false)
        {
            Console.WriteLine("Il termostato è spento. Accendilo prima di aumentare la temperatura.");
            return;
        }

        _temperature += increment;
        if (_temperature >= _maxThreshold)
        {
            ThermostatEventArgs args = new()
            {
                CurrentTemperature = _temperature,
                ThresholdExceededBy = _temperature - 100
            };

            // Se la soglia è raggiunta, solleva l'evento
            OnMaxThresholdReached?.Invoke(this, args);
        }
    }

    public void DecreaseTemperature(int decrement)
    {
        if (_status == false)
        {
            Console.WriteLine("Il termostato è spento. Accendilo prima di aumentare la temperatura.");
            return;
        }

        _temperature -= decrement;
        if (_temperature < _minThreshold)
        {
            ThermostatEventArgs args = new()
            {
                CurrentTemperature = _temperature,
                ThresholdExceededBy = _temperature - 100
            };

            // Se la soglia è raggiunta, solleva l'evento
            OnMinThresholdReached?.Invoke(this, args);
        }
    }

    public override string ToString()
    {
        return $"Temperatura: {_temperature}°C, Soglia Minima: {_minThreshold}°C, Soglia Massima: {_maxThreshold}°C";
    }
}