using System;

namespace PatternEDatabase.Mvp;

/// <summary>
/// Modello semplice che mantiene il valore di un contatore e notifica i cambiamenti.
/// </summary>
public class CounterModel
{
    public event Action<int>? OnCounterChanged;

    /// <summary>
    /// Valore corrente del contatore.
    /// </summary>
    public int Value { get; private set; }

    /// <summary>
    /// Incrementa il contatore e notifica la vista.
    /// </summary>
    public void Increment()
    {
        Value++;
        OnCounterChanged?.Invoke(Value);
    }

    /// <summary>
    /// Decrementa il contatore e notifica la vista.
    /// </summary>
    public void Decrement()
    {
        Value--;
        OnCounterChanged?.Invoke(Value);
    }

    /// <summary>
    /// Reimposta il valore a zero e notifica la vista.
    /// </summary>
    public void Reset()
    {
        Value = 0;
        OnCounterChanged?.Invoke(Value);
    }
}
