public class Program
{
    public static void Main(string[] args)
    {
        Thermostat thermostat = new(20, 100, 0);
        SenderSMS sender = new();

        // Iscrizione agli eventi
        thermostat.OnMaxThresholdReached += (senderObj, eventArgs) =>
        {
            Console.WriteLine($"[EVENTO] Soglia massima superata! Temperatura attuale: {eventArgs.CurrentTemperature}°C, Superata di: {eventArgs.ThresholdExceededBy}°C");
            sender.Send($"Allarme! La temperatura ha superato la soglia massima di {thermostat.MaxThreshold}°C ed è attualmente a {eventArgs.CurrentTemperature}°C.", "+391234567890");
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
    }
}