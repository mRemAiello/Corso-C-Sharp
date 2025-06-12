public class Library
{
    private BookLibrary[] _books = new BookLibrary[99];

    public void AddItem(Book item, int quantity)
    {
        Book? book = SearchBookByISBN(item.GetISBN());
        if (book == null)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i] == null)
                {
                    _books[i] = new BookLibrary
                    {
                        Book = item,
                        BooksRemainings = quantity,
                        BooksLoaned = 0
                    };
                }
            }
        }
        else
        {
            
        }
    }

    public void Loan(Book item)
    {
        // Cerca libro
        // Se c'è, controlli le copie disponibili, diminuisci di 1 e aumenta di 1 il Loan
        // Se non c'è, return con writeline (warning)
    }

    public Book? SearchBookByISBN(string? isbn)
    {
        foreach (BookLibrary bookLib in _books)
        {
            if (bookLib == null)
                continue;

            //
            Book? book = bookLib.Book;
            if (book == null)
                continue;

            //
            string? bookISBN = book.GetISBN();
            if (string.IsNullOrEmpty(bookISBN))
                continue;

            //
            if (bookISBN.Equals(isbn))
            {
                return book;
            }
        }

        return null;
    }
}