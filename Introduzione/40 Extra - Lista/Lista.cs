using System.Collections.Generic;

public class Nodo<T>
{
    public Nodo(T valore)
    {
        Valore = valore;
    }

    public T Valore { get; set; }
    public Nodo<T>? Successore { get; set; }
    public Nodo<T>? Predecessore { get; set; }
}

public class Lista<T>
{
    public Nodo<T>? Head { get; private set; }
    public Nodo<T>? Tail { get; private set; }
    public int Count { get; private set; }

    public void Add(T valore)
    {
        Nodo<T> nuovo = new(valore);
        if (Head == null)
        {
            Head = Tail = nuovo;
        }
        else
        {
            nuovo.Successore = Head;
            Head.Predecessore = nuovo;
            Head = nuovo;
        }
        Count++;
    }

    public void Append(T valore)
    {
        Nodo<T> nuovo = new(valore);
        if (Tail == null)
        {
            Head = Tail = nuovo;
        }
        else
        {
            Tail.Successore = nuovo;
            nuovo.Predecessore = Tail;
            Tail = nuovo;
        }
        Count++;
    }

    public bool Remove(T valore)
    {
        Nodo<T>? corrente = Head;
        while (corrente != null)
        {
            if (EqualityComparer<T>.Default.Equals(corrente.Valore, valore))
            {
                if (corrente.Predecessore != null)
                {
                    corrente.Predecessore.Successore = corrente.Successore;
                }
                else
                {
                    Head = corrente.Successore;
                }

                if (corrente.Successore != null)
                {
                    corrente.Successore.Predecessore = corrente.Predecessore;
                }
                else
                {
                    Tail = corrente.Predecessore;
                }

                Count--;
                return true;
            }
            corrente = corrente.Successore;
        }
        return false;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Nodo<T>? corrente = Head;
        for (int i = 0; i < index; i++)
        {
            corrente = corrente!.Successore;
        }

        return corrente!.Valore;
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public T Min()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Lista vuota");
        }

        T min = Head.Valore;
        Nodo<T>? corrente = Head.Successore;
        while (corrente != null)
        {
            if (Comparer<T>.Default.Compare(corrente.Valore, min) < 0)
            {
                min = corrente.Valore;
            }
            corrente = corrente.Successore;
        }

        return min;
    }

    public T Max()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Lista vuota");
        }

        T max = Head.Valore;
        Nodo<T>? corrente = Head.Successore;
        while (corrente != null)
        {
            if (Comparer<T>.Default.Compare(corrente.Valore, max) > 0)
            {
                max = corrente.Valore;
            }
            corrente = corrente.Successore;
        }

        return max;
    }
}

