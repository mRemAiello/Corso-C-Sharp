namespace PatternEDatabase.Composite;

public static class CompositePatternDemo
{
    public static void Run()
    {
        Console.WriteLine("Esempio di Composite: struttura di una cartella\n");

        var documents = new Folder("Documenti");
        var photos = new Folder("Foto");
        var travel = new Folder("Vacanze");

        var todo = new FileItem("todo.txt");
        var cv = new FileItem("cv.pdf");
        var rome = new FileItem("Roma.jpg");
        var paris = new FileItem("Parigi.jpg");

        travel.Add(rome);
        travel.Add(paris);

        photos.Add(travel);
        documents.Add(photos);
        documents.Add(todo);
        documents.Add(cv);

        Console.WriteLine("Stampa della gerarchia iniziale:\n");
        documents.Print();

        Console.WriteLine("\nRimuovo il file todo.txt dalla cartella Documenti.\n");
        documents.Remove(todo);

        Console.WriteLine("Stampa della gerarchia aggiornata:\n");
        documents.Print();
    }
}
