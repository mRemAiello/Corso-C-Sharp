public class Libreria
{
    private Libro[] _libri;

    //
    public Libreria(int capacita)
    {
        _libri = new Libro[capacita];
    }

    public void AggiungiLibro(Libro? libro)
    {
        if (libro == null)
            return;

        //
        Libro? libroInterno = CercaLibroPerISBN(libro.GetISBN());
        if (libroInterno != null)
        {
            int disponibilita = libroInterno.GetDisponibilita() + libro.GetDisponibilita();
            libroInterno.SetDisponibilita(disponibilita);
            Console.WriteLine($"Aumentata disponibilità del libro a {disponibilita}");
        }
        else
        {
            for (int i = 0; i < _libri.Length; i++)
            {
                if (_libri[i] == null)
                {
                    _libri[i] = libro;
                    Console.WriteLine("Libro aggiunto in libreria");
                    return;
                }
            }
        }

        //
        Console.WriteLine("Non è stato possibile aggiungere un libro");
    }

    public Libro? CercaLibroPerTitolo(string? titolo)
    {
        if (titolo == null)
            return null;

        foreach (Libro libro in _libri)
        {
            if (libro == null)
                continue;

            string? autoreLibro = libro.GetAutore();
            if (autoreLibro != null && autoreLibro.Equals(titolo))
                return libro;
        }
        return null;
    }

    public Libro? CercaLibroPerAutore(string? autore)
    {
        if (autore == null)
            return null;

        foreach (Libro libro in _libri)
        {
            if (libro == null)
                continue;

            string? autoreLibro = libro.GetAutore();
            if (autoreLibro != null && autoreLibro.Equals(autore))
                return libro;
        }
        return null;
    }

    public Libro? CercaLibroPerISBN(string? isbn)
    {
        if (isbn == null)
            return null;

        foreach (Libro libro in _libri)
        {
            if (libro != null && libro.GetISBN().Equals(isbn))
                return libro;
        }
        return null;
    }
}