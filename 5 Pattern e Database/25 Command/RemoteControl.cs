using System;
using System.Collections.Generic;

namespace PatternEDatabase.Command;

public class RemoteControl
{
    private readonly Dictionary<string, ICommand> _commands = new(StringComparer.OrdinalIgnoreCase);
    private readonly Stack<(string Name, ICommand Command)> _history = new();

    public void SetCommand(string label, ICommand command)
    {
        _commands[label] = command;
        Console.WriteLine($"[Config] Comando '{label}' registrato nel telecomando.");
    }

    public void PressButton(string label)
    {
        if (!_commands.TryGetValue(label, out var command))
        {
            Console.WriteLine($"[Remote] Nessun comando configurato per '{label}'.");
            return;
        }

        Console.WriteLine($"[Remote] Esecuzione del comando '{label}'.");
        command.Execute();
        _history.Push((label, command));
    }

    public void UndoLastCommand()
    {
        if (_history.Count == 0)
        {
            Console.WriteLine("[Remote] Nessun comando da annullare.");
            return;
        }

        var (label, command) = _history.Pop();
        Console.WriteLine($"[Remote] Annullamento dell'ultimo comando '{label}'.");
        command.Undo();
    }
}
