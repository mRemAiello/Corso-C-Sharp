using DelegateExample;
using EventExample;

public class Program
{
    static void Main(string[] args)
    {
        ConsoleView consoleView = new ConsoleView();
        UserViewModel userViewModel = new UserViewModel();
        UserController userController = new UserController(userViewModel, consoleView);

        userController.Run();
    }

    /*
    static void Main(string[] args)
    {
        Thermostat thermostat = new();

        // Iscrizione all'evento
        thermostat.ThresholdReached += HandleThresholdReached;

        // Aumento della temperatura
        thermostat.IncreaseTemperature(30);
        thermostat.IncreaseTemperature(40);

        // A questo punto l'evento verrà sollevato
        thermostat.IncreaseTemperature(50); 
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

        if (sender is Thermostat)
        {
            // Eventuali funzioni da richiamare nella classe che lancia l'evento
            Thermostat thermostat = (Thermostat)sender;
        }
    }*/
}