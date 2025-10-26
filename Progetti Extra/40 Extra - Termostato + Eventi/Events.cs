// Definizione del delegate che rappresenta la firma dei metodi gestori dell'evento
public delegate void ThresholdReachedEvent(object sender, ThermostatEventArgs e);
public delegate void ThermostatStatusEvent(object sender, ThermostatStatusEventsArgs e);

public class ThermostatEventArgs : EventArgs
{
    public int CurrentTemperature;
    public int ThresholdExceededBy;
}

public class ThermostatStatusEventsArgs : EventArgs
{
    public bool Status;
}