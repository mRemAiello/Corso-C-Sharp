namespace PatternEDatabase.State;

/// <summary>
/// Definisce il contratto per tutti gli stati possibili di un ordine.
/// Ogni stato decide come gestire le azioni e a quale stato passare.
/// </summary>
public interface IOrderState
{
    /// <summary>
    /// Nome descrittivo dello stato corrente.
    /// </summary>
    string Name { get; }

    void Pay(OrderContext context);

    void Ship(OrderContext context);

    void Cancel(OrderContext context);
}