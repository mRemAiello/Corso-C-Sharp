public class FileView : IView
{
    public void MostraDettagli(string header, Dictionary<string, string> dettagli)
    {
        using (var writer = new StreamWriter("output.txt", true))
        {
            writer.WriteLine($"----- {header} -----");
            foreach (var dettaglio in dettagli)
            {
                writer.WriteLine($"{dettaglio.Key}: {dettaglio.Value}");
            }
            writer.WriteLine();
        }
    }

    public void MostraMessaggio(string messaggio)
    {
        using (var writer = new StreamWriter("output.txt", true))
        {
            writer.WriteLine(messaggio);
            writer.WriteLine();
        }
    }
}