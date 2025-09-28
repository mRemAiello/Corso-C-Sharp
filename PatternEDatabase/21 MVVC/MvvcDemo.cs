using System;

/// <summary>
/// Dimostrazione minimale per l'architettura Model-View-ViewModel-Controller.
/// </summary>
public static class MvvcDemo
{
    public static void Run()
    {
        Console.WriteLine("=== MVVC Demo ===");
        Console.WriteLine("Il controller orchestrerà l'interazione con l'utente tramite la console.\n");

        var viewModel = new UserViewModel();
        var view = new ConsoleView();
        var controller = new UserController(viewModel, view);

        controller.Run();
    }
}
