using System.Runtime.ExceptionServices;

public enum Colors
{
    Rosso = 0,
    Blu = 1
}

public interface IColorable
{
    public abstract Colors GetColor();
}

public class Auto2 : Veicolo, IColorable
{
    public Colors GetColor()
    {
        return Colors.Rosso;
    }
}

public class Penna : IColorable
{
    public Colors GetColor()
    {
        return Colors.Rosso;
    } 
}

public class CoppiaColorabile<T1, T2> where T1 : IColorable where T2 : IColorable
{
    private T1? _first;

    public T3? Convert<T3>() where T3 : class
    {
        if (_first is T3)
            return (T3)(object)_first;
        return null;
    }
}