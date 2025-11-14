using System;

namespace PatternEDatabase.Mvp;

/// <summary>
/// Punto di ingresso per la dimostrazione MVP.
/// </summary>
public static class MvpDemo
{
    public static void Run()
    {
        Console.WriteLine("Avvio della dimostrazione Model-View-Presenter.\n");

        var model = new CounterModel();
        var view = new FileViewMVC();
        var controller = new CounterController(model, view);

        controller.Run();
    }
}
