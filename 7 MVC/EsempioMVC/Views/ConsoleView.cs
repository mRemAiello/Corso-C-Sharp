namespace EsempioMVC.Views
{
    // View: si occupa solo della presentazione dei dati, non contiene logica applicativa
    public class ConsoleView : IView
    {
        // Funzione generica per mostrare i dettagli con un header personalizzato
        public void MostraDettagli(string header, Dictionary<string, string> dettagli)
        {
            Console.WriteLine($"----- {header} -----");
            foreach (var dettaglio in dettagli)
            {
                Console.WriteLine($"{dettaglio.Key}: {dettaglio.Value}");
            }
            Console.WriteLine("----------------------------\n");
        }

        public void MostraMessaggio(string messaggio)
        {
            Console.WriteLine(messaggio);
        }
    }
}
