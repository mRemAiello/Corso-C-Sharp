namespace EventExample
{
    // Definizione del delegate che rappresenta la firma dei metodi gestori dell'evento
    public delegate void ThresholdReachedEventHandler(object sender, EventArgs e);

    // Classe che genera l'evento
    class Thermostat
    {
        private int _temperature;

        // Definizione dell'evento
        public event ThresholdReachedEventHandler ThresholdReached;

        // Metodo per aumentare la temperatura
        public void IncreaseTemperature(int increment)
        {
            _temperature += increment;
            Console.WriteLine("Temperatura attuale: " + _temperature);

            // Verifica se la temperatura supera la soglia di 100 gradi
            if (_temperature >= 100)
            {
                // Se la soglia è raggiunta, solleva l'evento
                OnThresholdReached(EventArgs.Empty);
            }
        }

        // Metodo che solleva l'evento
        protected virtual void OnThresholdReached(EventArgs e)
        {
            // Se qualcuno è iscritto all'evento, lo notifichiamo
            ThresholdReached?.Invoke(this, e);
        }
    }

    class EventEx
    {
        public void Execute()
        {
            Thermostat thermostat = new Thermostat();

            // Iscrizione all'evento
            thermostat.ThresholdReached += HandleThresholdReached;

            // Aumento della temperatura
            thermostat.IncreaseTemperature(30);
            thermostat.IncreaseTemperature(40);
            thermostat.IncreaseTemperature(50); // A questo punto l'evento verrà sollevato
        }

        // Metodo gestore dell'evento
        static void HandleThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("La soglia di temperatura è stata raggiunta!");
        }
    }
}