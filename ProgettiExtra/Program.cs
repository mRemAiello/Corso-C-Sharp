using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace ProgettiExtraApp;

public static class Program
{
    public static async Task Main(string[] args)
    {
        Rubrica rubrica = new Rubrica();

        Contatto contatto = new Contatto("Mario Rossi", "mario.rossi@gmai.com", "340");
        rubrica.OnContattoAggiunto += OnContattoAggiunto;

        Console.WriteLine("Pre aggiunta");
        rubrica.AggiungiContatto(contatto);
        Console.WriteLine("Post aggiunta");

        Console.WriteLine();
        Console.WriteLine("Verifica disponibilità serie TV su Netflix:\n");

        List<string> serieDaVerificare =
        [
            "Stranger Things",
            "Breaking Bad",
            "La casa di carta",
            "The Office",
            "The Witcher"
        ];

        NetflixCatalogApiClient netflixApiClient = new();

        HashSet<string> catalogoNetflix;

        try
        {
            catalogoNetflix = await netflixApiClient.GetCatalogAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Impossibile caricare il catalogo da Netflix API: {ex.Message}");
            Console.WriteLine("Utilizzo un catalogo locale di fallback per l'esempio.\n");

            catalogoNetflix = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Stranger Things",
                "La casa di carta",
                "The Witcher",
                "Dark",
                "Narcos"
            };
        }

        foreach (string serie in serieDaVerificare)
        {
            bool disponibile = catalogoNetflix.Contains(serie);
            string messaggio = disponibile
                ? $"La serie \"{serie}\" è disponibile su Netflix."
                : $"La serie \"{serie}\" non è disponibile su Netflix.";

            Console.WriteLine(messaggio);
        }
    }

    private static void OnContattoAggiunto(Contatto contatto)
    {
        Console.WriteLine($"Contatto aggiunto: {contatto}, dalla classe Program funzione Main");
    }
}

internal sealed class NetflixCatalogApiClient
{
    private static readonly HttpClient HttpClient = CreateHttpClient();
    private const string CatalogEndpoint = "https://apis.justwatch.com/content/titles/it_IT/popular";

    public async Task<HashSet<string>> GetCatalogAsync(CancellationToken cancellationToken = default)
    {
        JustWatchCatalogRequest requestBody = new(pageSize: 100, page: 1, query: string.Empty, providers: new[] { "nfx" });

        string serializedRequest = JsonSerializer.Serialize(requestBody, new JsonSerializerOptions(JsonSerializerDefaults.Web));

        using HttpRequestMessage request = new(HttpMethod.Post, CatalogEndpoint)
        {
            Content = new StringContent(serializedRequest, Encoding.UTF8, "application/json")
        };

        using HttpResponseMessage response = await HttpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        await using Stream contentStream = await response.Content.ReadAsStreamAsync(cancellationToken);
        JustWatchCatalogResponse? responseContent = await JsonSerializer.DeserializeAsync<JustWatchCatalogResponse>(
            contentStream,
            new JsonSerializerOptions(JsonSerializerDefaults.Web),
            cancellationToken);

        if (responseContent?.Items is null || responseContent.Items.Length == 0)
        {
            return new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        return responseContent.Items
            .Select(item => item.Title)
            .Where(title => !string.IsNullOrWhiteSpace(title))
            .Select(title => title!.Trim())
            .ToHashSet(StringComparer.OrdinalIgnoreCase);
    }

    private static HttpClient CreateHttpClient()
    {
        HttpClient httpClient = new();

        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        httpClient.DefaultRequestHeaders.AcceptLanguage.ParseAdd("it-IT,it;q=0.9,en;q=0.8");
        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("ProgettiExtraApp/1.0");

        return httpClient;
    }

    private sealed record JustWatchCatalogRequest(
        [property: JsonPropertyName("page_size")] int PageSize,
        [property: JsonPropertyName("page")] int Page,
        [property: JsonPropertyName("query")] string Query,
        [property: JsonPropertyName("providers")] string[] Providers);

    private sealed record JustWatchCatalogResponse(
        [property: JsonPropertyName("items")] JustWatchItem[]? Items);

    private sealed record JustWatchItem([property: JsonPropertyName("title")] string? Title);
}
