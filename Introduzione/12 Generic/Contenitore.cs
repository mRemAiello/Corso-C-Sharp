public class Contenitore<T> where T : Liquido
{
    private T? _contenuto;

    public T? Contenuto => _contenuto;

    public Contenitore(T? contenuto)
    {
        _contenuto = contenuto;
    }

    public void Aggiungi(T nuovoElemento)
    {
        _contenuto = nuovoElemento;
    }
}