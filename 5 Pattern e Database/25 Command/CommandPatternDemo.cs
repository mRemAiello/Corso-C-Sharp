using System;

namespace PatternEDatabase.Command;

public static class CommandPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Pattern Command ===");
        Console.WriteLine("Questo esempio dimostra come il Command disaccoppi invoker, comando e receiver.\n");

        var luceSoggiorno = new Light("del soggiorno");
        var accendiLuce = new LightOnCommand(luceSoggiorno);
        var spegniLuce = new LightOffCommand(luceSoggiorno);

        var telecomando = new RemoteControl();
        telecomando.SetCommand("Luce soggiorno ON", accendiLuce);
        telecomando.SetCommand("Luce soggiorno OFF", spegniLuce);

        Console.WriteLine();
        telecomando.PressButton("Luce soggiorno ON");
        telecomando.PressButton("Luce soggiorno OFF");
        telecomando.UndoLastCommand();
        telecomando.UndoLastCommand();
        telecomando.UndoLastCommand();
    }
}
