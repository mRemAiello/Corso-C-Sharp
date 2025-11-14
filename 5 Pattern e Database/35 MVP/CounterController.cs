using System;

namespace PatternEDatabase.Mvp;

/// <summary>
/// Controller che coordina il modello e la vista secondo l'architettura MVP.
/// </summary>
public class CounterController
{
    private readonly CounterModel _model;
    private readonly ICounterView _view;
    private bool _isRunning;

    public CounterController(CounterModel model, ICounterView view)
    {
        _model = model;
        _view = view;
        _model.OnCounterChanged += OnCounterChanged;
    }

    public void Run()
    {
        _isRunning = true;
        _view.ShowWelcome();
        _view.ShowValue(_model.Value);

        while (_isRunning)
        {
            var command = _view.ReadCommand();
            if (command is null)
            {
                continue;
            }

            HandleCommand(command.Trim().ToLowerInvariant());
        }

        _view.ShowGoodbye();
    }

    private void HandleCommand(string command)
    {
        switch (command)
        {
            case "i":
            case "+":
            case "incrementa":
                _model.Increment();
                break;
            case "d":
            case "-":
            case "decrementa":
                _model.Decrement();
                break;
            case "r":
            case "reset":
                _model.Reset();
                break;
            case "q":
            case "esci":
                _isRunning = false;
                break;
            default:
                _view.ShowUnknownCommand(command);
                break;
        }
    }

    private void OnCounterChanged(int newValue)
    {
        _view.ShowValue(newValue);
    }
}
