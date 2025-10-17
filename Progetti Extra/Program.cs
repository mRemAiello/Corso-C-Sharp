public class Program
{
    public static void Main(string[] args)
    {
        Thermostat thermostat = new(20, 100, 0);

        // Iscrizione agli eventi
        thermostat.OnMaxThresholdReached += (senderObj, eventArgs) =>
        {
            LogWriter.Instance.WriteLine($"[EVENTO] Soglia massima superata! Temperatura attuale: {eventArgs.CurrentTemperature}°C, Superata di: {eventArgs.ThresholdExceededBy}°C");
            SenderSMS.Instance.Send("+391234567890", $"Allarme! La temperatura ha superato la soglia massima di {thermostat.MaxThreshold}°C ed è attualmente a {eventArgs.CurrentTemperature}°C.");
        };

        //
        Console.WriteLine("Benvenuto nel termostato");
        thermostat.Start();

        // Inizio programma
        Console.WriteLine("Inserisci comando (0 = aumenta temperatura, 1 = diminuisci temperatura, 2 = esci):");
        string? cmd = Console.ReadLine();
        while (cmd != "2")
        {
            // Esegui il comando
            if (cmd == "0")
            {
                Console.WriteLine("Di quanto vuoi aumentare la temperatura?");
                int tmp = Convert.ToInt32(Console.ReadLine() ?? "0");
                thermostat.IncreaseTemperature(tmp);
            }
            else if (cmd == "1")
            {
                Console.WriteLine("Di quanto vuoi diminuire la temperatura?");
                int tmp = Convert.ToInt32(Console.ReadLine() ?? "0");
                thermostat.DecreaseTemperature(tmp);
            }
            else
            {
                Console.WriteLine("Comando non valido.");
            }

            // Mostra lo stato attuale del termostato
            Console.WriteLine("Situazione termostato attuale:");
            Console.WriteLine(thermostat);
            Console.WriteLine();

            // Prompt per il prossimo comando
            Console.WriteLine("Inserisci comando (0 = aumenta temperatura, 1 = diminuisci temperatura, 2 = esci):");
            cmd = Console.ReadLine();
        }

        //
        thermostat.ShutDown();

        // 
        SenderSMS.Instance.Send("320204394", "Il termostato XY si è spento");
    }
}