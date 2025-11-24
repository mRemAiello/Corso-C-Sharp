using System.Collections;

namespace ProgettiExtra.Biblioteca;

// DatabaseManager -> Singleton
// Libreria (100 istanze)

public class Libreria : IEnumerable
{
    private Libro[] _libri;
    private Utente[] _utenti;
    private Prestito?[] _prestiti;

    //
    public Libreria(int capacita)
    {
        _libri = new Libro[capacita];
        _utenti = new Utente[9999];
        _prestiti = new Prestito[9999];
    }

    private bool PuoEseguireOperazione(Utente utente, Permessi permesso)
    {
        if (utente.GetPermessi() == Permessi.Nessuno)
            return false;

        //
        if (utente.GetPermessi() == Permessi.Amministratore)
            return true;

        //
        return utente.GetPermessi().HasFlag(permesso);
    }

    public void AggiungiUtente(Utente? utente, Utente? nuovoUtente)
    {
        if (utente == null || nuovoUtente == null)
        {
            Console.WriteLine("L'utente non può essere null");
            return;
        }

        //
        if (!PuoEseguireOperazione(utente, Permessi.Aggiungere))
        {
            Console.WriteLine("L'utente non ha la possibilità di aggiungere libri");
            return;
        }

        //
        if (CercaUtentePerID(nuovoUtente.GetID()) != null)
        {
            Console.WriteLine("L'utente è già inserito nel database");
            return;
        }

        //
        for (int i = 0; i < _utenti.Length; i++)
        {
            if (_utenti[i] == null)
            {
                _utenti[i] = nuovoUtente;
                Console.WriteLine("Utente inserito nel database");
                return;
            }
        }

        //
        Console.WriteLine("Non c'è spazio nel database");
    }

    public Utente? CercaUtentePerID(int id)
    {
        foreach (Utente utente in _utenti)
        {
            if (utente != null && utente.GetID() == id)
            {
                return utente;
            }
        }
        return null;
    }

    public void AggiungiLibro(Utente utente, Libro? libro)
    {
        if (libro == null)
        {
            Console.WriteLine("Il libro non può essere null");
            return;
        }

        //
        if (!PuoEseguireOperazione(utente, Permessi.Aggiungere))
        {
            Console.WriteLine("L'utente non ha la possibilità di aggiungere libri");
            return;
        }

        //
        Libro? libroInterno = CercaLibroPerISBN(utente, libro.GetISBN());
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

    public Libro? CercaLibroPerTitolo(Utente utente, string titolo)
    {
        //
        if (!PuoEseguireOperazione(utente, Permessi.Cerca))
        {
            Console.WriteLine("L'utente non ha la possibilità di cercare tra i libri");
            return null;
        }

        //
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

    public Libro? CercaLibroPerAutore(Utente utente, string autore)
    {
        //
        if (!PuoEseguireOperazione(utente, Permessi.Cerca))
        {
            Console.WriteLine("L'utente non ha la possibilità di cercare tra i libri");
            return null;
        }

        //
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

    public Libro? CercaLibroPerISBN(Utente utente, string isbn)
    {
        //
        if (!PuoEseguireOperazione(utente, Permessi.Cerca))
        {
            Console.WriteLine("L'utente non ha la possibilità di cercare tra i libri");
            return null;
        }

        //
        foreach (Libro libro in _libri)
        {
            if (libro == null)
                continue;

            //
            string? libroISBN = libro.GetISBN();
            if (libroISBN != null && libroISBN.Equals(isbn))
            {
                return libro;
            }
        }
        return null;
    }

    public void PrendiInPrestito(Utente utente, Cliente cliente, string isbn)
    {
        if (utente == null || cliente == null)
        {
            Console.WriteLine("L'utente non può essere null");
            return;
        }

        //
        if (isbn == null)
        {
            Console.WriteLine("L'isbn non può essere null");
            return;
        }

        //
        if (!PuoEseguireOperazione(utente, Permessi.Prestito))
        {
            Console.WriteLine("L'utente non ha la possibilità di aggiungere libri");
            return;
        }

        //
        Libro? libroInterno = CercaLibroPerISBN(utente, isbn.ToUpper());
        if (libroInterno == null)
        {
            Console.WriteLine("Il libro non si trova nel database");
            return;
        }

        //
        if (libroInterno.GetDisponibilita() <= 0)
        {
            Console.WriteLine("Il libro non ha nessuna disponibilità");
            return;
        }

        //
        for (int i = 0; i < _prestiti.Length; i++)
        {
            if (_prestiti[i] == null)
            {
                _prestiti[i] = new Prestito(cliente, libroInterno);
                libroInterno.SetDisponibilita(libroInterno.GetDisponibilita() - 1);
                Console.WriteLine("Il libro è stato prestato con successo");
                return;
            }
        }

        //
        Console.WriteLine("Non c'è spazio per ulteriori prestiti");
    }

    public void RestituzionePrestito(Utente utente, Cliente cliente, string isbn)
    {
        if (utente == null || cliente == null)
        {
            Console.WriteLine("L'utente non può essere null");
            return;
        }

        //
        if (isbn == null)
        {
            Console.WriteLine("L'isbn non può essere null");
            return;
        }

        //
        if (!PuoEseguireOperazione(utente, Permessi.Restituire))
        {
            Console.WriteLine("L'utente non ha la possibilità di aggiungere libri");
            return;
        }

        //
        Libro? libroInterno = CercaLibroPerISBN(utente, isbn.ToUpper());
        if (libroInterno == null)
        {
            Console.WriteLine("Il libro non si trova nel database");
            return;
        }

        //
        for (int i = 0; i < _prestiti.Length; i++)
        {
            if (_prestiti[i] == null)
                continue;

            //
            var prestitoCorrente = _prestiti[i];
            if (prestitoCorrente?.GetCliente() == null || prestitoCorrente.GetLibro() == null)
                continue;

            //
            int idPrestito = prestitoCorrente.GetCliente().GetID();
            string isbnPrestito = prestitoCorrente.GetLibro().GetISBN();
            if (idPrestito == cliente.GetID() && isbnPrestito.Equals(isbn.ToUpper()))
            {
                _prestiti[i] = null;
                libroInterno.SetDisponibilita(libroInterno.GetDisponibilita() + 1);
                Console.WriteLine("Il libro è stato restituito con successo");
                return;
            }
        }
    }

    //
    public override string ToString()
    {
        string ret = "Libri:\n";
        foreach (Libro libro in _libri)
        {
            if (libro != null)
                ret += $"{libro}\n";
        }
        ret += "Utenti:\n";
        foreach (Utente utente in _utenti)
        {
            if (utente != null)
                ret += $"{utente}\n";
        }
        ret += "Prestiti:\n";
        foreach (Prestito? prestito in _prestiti)
        {
            if (prestito != null)
                ret += $"{prestito}\n";
        }
        return ret;
    }

    public IEnumerator GetEnumerator()
    {
        Libro[] libri = new Libro[_libri.Length];
        _libri.CopyTo(libri, 0);
        return libri.GetEnumerator();
    }
}