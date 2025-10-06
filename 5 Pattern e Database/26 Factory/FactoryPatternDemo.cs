using System.Text;

namespace PatternEDatabase.Factory;

public static class FactoryPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("--- Factory Method ---");
        RunFactoryMethodDemo();
        Console.WriteLine();

        Console.WriteLine("--- Abstract Factory ---");
        RunAbstractFactoryDemo();
    }

    private static void RunFactoryMethodDemo()
    {
        Logistics roadLogistics = new RoadLogistics();
        Logistics seaLogistics = new SeaLogistics();

        Console.WriteLine(roadLogistics.PlanDelivery("componenti elettronici"));
        Console.WriteLine(seaLogistics.PlanDelivery("arredamento"));
    }

    private static void RunAbstractFactoryDemo()
    {
        ShowDeviceExperience(new AndroidDeviceFactory());
        Console.WriteLine();
        ShowDeviceExperience(new AppleDeviceFactory());
    }

    private static void ShowDeviceExperience(IDeviceFactory factory)
    {
        ISmartphone smartphone = factory.CreateSmartphone();
        ITablet tablet = factory.CreateTablet();

        var builder = new StringBuilder();
        builder.AppendLine($"Prodotti creati da {factory.GetType().Name}:");
        builder.AppendLine($" - Smartphone: {smartphone.Name}");
        builder.AppendLine($"   {smartphone.Call("Mario")}");
        builder.AppendLine($" - Tablet: {tablet.Name}");
        builder.AppendLine($"   {tablet.WatchVideo("Design Patterns in pratica")}");

        Console.Write(builder.ToString());
    }
}
