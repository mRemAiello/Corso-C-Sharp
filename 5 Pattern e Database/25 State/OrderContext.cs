namespace PatternEDatabase.State;

/// <summary>
/// Contesto che mantiene lo stato corrente di un ordine e delega le azioni allo stato.
/// </summary>
public class OrderContext
{
    private IOrderState _state;

    public OrderContext()
    {
        _state = new NewOrderState();
    }

    public string Status => _state.Name;

    internal void TransitionTo(IOrderState nextState)
    {
        _state = nextState;
    }

    public void Pay() => _state.Pay(this);

    public void Ship() => _state.Ship(this);

    public void Cancel() => _state.Cancel(this);
}
