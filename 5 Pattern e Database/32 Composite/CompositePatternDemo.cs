namespace PatternEDatabase.Composite;

public static class CompositePatternDemo
{
    public static void Run()
    {
        Console.WriteLine("Esempio di Composite: struttura di una cartella\n");

        var documents = new Folder("Documenti");
        var photos = new Folder("Foto");
        var travel = new Folder("Vacanze");

        var todo = new FileItem("todo.txt", 20);
        var cv = new FileItem("cv.pdf", 50);
        var rome = new FileItem("Roma.jpg", 20);
        var paris = new FileItem("Parigi.jpg", 35);

        travel.Add(rome);
        travel.Add(paris);

        photos.Add(travel);
        documents.Add(photos);
        documents.Add(todo);
        documents.Add(cv);

        // Documents 125 -> Photos 55 -> Travel 55 -> [Rome.jpg 20, Paris.jpg 35]
        // Documents -> [todo.txt 20, cv.pdf 50]

        Console.WriteLine("Stampa della gerarchia iniziale:\n");
        documents.Print();

        Console.WriteLine("\nRimuovo il file todo.txt dalla cartella Documenti.\n");
        documents.Remove(todo);

        Console.WriteLine("Stampa della gerarchia aggiornata:\n");
        documents.Print();
    }
}
