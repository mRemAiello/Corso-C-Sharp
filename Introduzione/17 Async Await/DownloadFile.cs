public class DownloadFile
{
    static async Task Main(string[] args)
    {
        string url = "https://www.example.com";

        // Avvio del download della pagina
        string contenutoPagina = await ScaricaPaginaAsync(url);

        // Visualizzazione del contenuto scaricato
        Console.WriteLine(contenutoPagina);
    }

    // Metodo asincrono che scarica il contenuto di una pagina web
    static async Task<string> ScaricaPaginaAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            // Scarica il contenuto della pagina in modo asincrono
            string contenuto = await client.GetStringAsync(url);
            return contenuto;
        }
    }
}