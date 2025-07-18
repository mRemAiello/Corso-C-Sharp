class Program
{
    static void Main(string[] args)
    {
        Libro libro = new("AX01", "Signore degli Anelli", "JRR Tolkien", 1950, 20);
        Libro libro2 = new("AX02", "Harry Potter e la pietra filosofale", "Rowling", 1990, 30);

        Console.WriteLine(libro);
        Console.WriteLine(libro2);

        Libreria libreria = new(40);
        libreria.AggiungiLibro(libro);
        libreria.AggiungiLibro(libro2);
        Libro? libroCerca = libreria.CercaLibroPerISBN("AX01");
        if (libroCerca != null)
        {
            Console.WriteLine(libroCerca);
        }


        Data data1 = new Data(20, 1, 2025);
        Data data2 = new Data(1, 2, 2025);
        Console.WriteLine(data1.CompareTo(data2));
        Console.WriteLine(data1.Equals(data2));
    }
}