using System;

namespace PatternEDatabase.Observer;

/// <summary>
/// Dimostrazione concreta del pattern Observer applicato ad una stazione meteorologica.
/// </summary>
public static class ObserverPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Observer Pattern: Stazione Meteo ===");

        var station = new WeatherStation();

        var kitchenDisplay = new ConsoleWeatherObserver("Display cucina");
        var mobileAppDisplay = new ConsoleWeatherObserver("App meteo");
        var statisticsObserver = new StatisticsWeatherObserver();

        using var kitchenSubscription = station.Subscribe(kitchenDisplay);
        var mobileSubscription = station.Subscribe(mobileAppDisplay);
        using var statisticsSubscription = station.Subscribe(statisticsObserver);

        station.UpdateMeasurements(22.4m, 58, 1013.5m);
        station.UpdateMeasurements(23.1m, 55, 1012.8m);
        station.UpdateMeasurements(24.6m, 52, 1011.9m);

        Console.WriteLine("--- L'app meteo si disiscrive dagli aggiornamenti ---");
        mobileSubscription.Dispose();

        station.UpdateMeasurements(19.8m, 68, 1015.2m);

        Console.WriteLine();
        Console.WriteLine(statisticsObserver.BuildReport());
        Console.WriteLine();
    }
}
