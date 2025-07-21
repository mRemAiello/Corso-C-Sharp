class Program
{
    static void Main(string[] args)
    {
        Libro libro = new("AX01", "Signore degli Anelli", "JRR Tolkien", 1950, 20);
        Libro libro2 = new("AX02", "Harry Potter e la pietra filosofale", "Rowling", 1990, 30);
        Libro libro3 = new("AX03", "Le cronache del ghiaccio e del fuoco", "Martin", 1990, 40);
        Libro libro4 = new("AX04", "Signore degli Anelli - Le due torri", "JRR Tolkien", 1950, 20);

        Utente utente = new(10);
        Amministratore admin = new(1);
        Cliente cliente = new(2);
        Dipendente dipendente = new(3);

        //
        Libreria libreria = new(40);
        libreria.AggiungiUtente(dipendente, utente);
        libreria.AggiungiUtente(dipendente, admin);
        libreria.AggiungiUtente(dipendente, cliente);
        libreria.AggiungiUtente(dipendente, dipendente);
        libreria.AggiungiLibro(admin, libro);
        libreria.AggiungiLibro(dipendente, libro2);
        libreria.AggiungiLibro(dipendente, libro3);
        libreria.AggiungiLibro(dipendente, libro3);

        //
        while (true)
        {
            Console.WriteLine("Esegui un comando: (1: Aggiungi libro, 2: Rimuovi libro, 3: Prestito, 4: Restituzione, 5: Visualizza Libreria, -1: Esci)");
            int comando = Convert.ToInt32(Console.ReadLine());
            if (comando == 1)
            {
                Console.WriteLine("Inserisci ISBN");
                string? isbn = Console.ReadLine();
                isbn ??= "";
                Console.WriteLine("Inserisci Titolo");
                string? titolo = Console.ReadLine();
                titolo ??= "";
                Console.WriteLine("Inserisci Autore");
                string? autore = Console.ReadLine();
                autore ??= "";
                Console.WriteLine("Inserisci Anno");
                int anno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci Disponibilità");
                int disp = Convert.ToInt32(Console.ReadLine());
                Libro tmpLibro = new(isbn, titolo, autore, anno, disp);
                libreria.AggiungiLibro(admin, tmpLibro);
            }
            else if (comando == 2)
            {

            }
            else if (comando == 3)
            {
                Console.WriteLine("Inserisci ISBN");
                string? isbn = Console.ReadLine();
                isbn ??= "";
                libreria.PrendiInPrestito(admin, cliente, isbn);
            }
            else if (comando == 4)
            {
                Console.WriteLine("Inserisci ISBN");
                string? isbn = Console.ReadLine();
                isbn ??= "";
                libreria.RestituzionePrestito(admin, cliente, isbn);
            }
            else if (comando == 5)
            {
                Console.WriteLine(libreria);
            }
            else if (comando == -1)
            {
                Console.WriteLine("Esco...");
                break;
            }
            else
            {
                Console.WriteLine("Comando non riconosciuto");
            }
        }
    }
}