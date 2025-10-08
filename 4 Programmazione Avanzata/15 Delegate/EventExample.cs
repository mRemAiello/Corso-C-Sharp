namespace EventExample
{
    // Definizione del delegate che rappresenta la firma dei metodi gestori dell'evento
    public delegate void ThresholdReachedEvent(object sender, EventArgs e);

    class ThermostatEventArgs : EventArgs
    {
        public int TemperaturaCorrente;
        public int SogliaDiSuperamento;
    }

    // Classe che genera l'evento
    class Thermostat
    {
        private int _temperature;

        // Definizione dell'evento
        public event ThresholdReachedEvent? OnThresholdReached;

        // Metodo per aumentare la temperatura
        public void IncreaseTemperature(int increment)
        {
            _temperature += increment;

            // Verifica se la temperatura supera la soglia di 100 gradi
            if (_temperature >= 100)
            {
                ThermostatEventArgs args = new()
                {
                    TemperaturaCorrente = _temperature,
                    SogliaDiSuperamento = _temperature - 100
                };

                // Se la soglia è raggiunta, solleva l'evento
                OnThresholdReached?.Invoke(this, args);

                //
                // SMSSender.Send("Soglia di temperatura superata!");
                // EmailSender.Send("Soglia di temperatura superata!");
                // LogWriter.Write("Soglia di temperatura superata!");
                // 
            }
        }
    }

    // SmsSender -> ThresholdReached -> Send()

    class EventEx
    {
        public void Execute()
        {
            Thermostat thermostat = new Thermostat();

            // Iscrizione all'evento
            thermostat.OnThresholdReached += HandleThresholdReached;

            // SmsSender smsSender = new SmsSender(3464471541);
            // thermostat.ThresholdReached += smsSender.Send;

            // LogWriter logWriter = new LogWriter("log.txt");
            // thermostat.ThresholdReached += logWriter.Write;

            // Aumento della temperatura
            thermostat.IncreaseTemperature(30);
            thermostat.IncreaseTemperature(40);
            thermostat.IncreaseTemperature(50); // A questo punto l'evento verrà sollevato
        }

        // Metodo gestore dell'evento
        static void HandleThresholdReached(object sender, EventArgs e)
        {
            if (e is ThermostatEventArgs)
            {
                ThermostatEventArgs args = (ThermostatEventArgs)e;
                Console.WriteLine("Soglia di temperatura superata di " + args.SogliaDiSuperamento);
                Console.WriteLine("Temperatura attuale: " + args.TemperaturaCorrente);
            }
        }
    }
}