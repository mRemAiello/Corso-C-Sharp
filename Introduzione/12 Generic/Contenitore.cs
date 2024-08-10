public class Contenitore<T>
{
    private T _elemento;

    public void Aggiungi(T nuovoElemento)
    {
        _elemento = nuovoElemento;
    }

    public T Ottieni()
    {
        return _elemento;
    }
}