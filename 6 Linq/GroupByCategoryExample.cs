namespace LinqExamples;

public record Libro(string Titolo, string Categoria);

public static class GroupByCategoryExample
{
    public static void Execute()
    {
        List<Libro> libri = new()
        {
            new("Il Signore degli Anelli", "Fantasy"),
            new("Harry Potter e la Pietra Filosofale", "Fantasy"),
            new("Il Codice Da Vinci", "Thriller"),
            new("Sherlock Holmes", "Giallo"),
            new("1984", "Distopico"),
            new("Fahrenheit 451", "Distopico"),
            new("Angeli e Demoni", "Thriller")
        };

        IEnumerable<IGrouping<string, Libro>> libriPerCategoria = libri.GroupBy(libro => libro.Categoria);

        Console.WriteLine("GroupBy - Libri raggruppati per categoria:");
        foreach (IGrouping<string, Libro> gruppo in libriPerCategoria)
        {
            Console.WriteLine($"Categoria: {gruppo.Key}");

            foreach (Libro libro in gruppo)
            {
                Console.WriteLine($"- {libro.Titolo}");
            }

            Console.WriteLine();
        }
    }
}
