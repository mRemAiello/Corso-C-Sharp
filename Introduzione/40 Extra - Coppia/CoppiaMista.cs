public class CoppiaMista<T1, T2> where T1 : Persona where T2 : Persona
{
    private T1 _primo;
    private T2 _secondo;

    public CoppiaMista(T1 primo, T2 secondo)
    {
        _primo = primo;
        _secondo = secondo;
    }

    //
    public T1 GetPrimo() => _primo;
    public T2 GetSecondo() => _secondo;
    public bool Check() => _primo.GetType().Equals(_secondo.GetType());
    public bool CheckSameFirst<T3>(T3 terzo) where T3 : Persona
    {
        return _primo.Equals(terzo);
    }

    //
    public override string ToString()
    {
        return $"Coppia formata da {_primo} e {_secondo}";
    }
}