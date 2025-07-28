public class Nodo<T>
{
    public Nodo<T>? successore;
    public Nodo<T>? predecessore;
    public T? valore;
}

public class Lista<T>
{
    public Nodo<T> head;
    public Nodo<T> tail;

    // nodo2.successore = nodo4;
    // nodo4.precedessore = nodo2;
}

// int * 999999 array
// lista Libro 