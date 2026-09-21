public class EsempioNullable
{
    public void Execute()
    {
        // Un tipo "nullable" puo rappresentare sia un valore sia l'assenza di un valore (null).
        // E utile, per esempio, quando un dato e facoltativo o non e ancora conosciuto.
        // Un int normale deve sempre contenere un numero; aggiungendo ? puo contenere anche null.
        int? eta = null;

        // int? e la forma abbreviata di Nullable<int>: le due dichiarazioni sono equivalenti.
        Nullable<int> voto = 8;

        // HasValue permette di sapere se il nullable contiene un valore.
        // Value lo restituisce, ma va usato soltanto dopo il controllo: se il valore fosse null,
        // provocherebbe un'InvalidOperationException.
        if (voto.HasValue)
        {
            Console.WriteLine($"Il voto e {voto.Value}.");
        }

        // Il pattern matching e un modo piu compatto e sicuro per controllare e leggere il valore.
        // Dentro l'if, etaInserita e un int non nullable.
        eta = 25;
        if (eta is int etaInserita)
        {
            Console.WriteLine($"L'eta inserita e {etaInserita} anni.");
        }

        // L'operatore ?? fornisce un valore predefinito quando il dato a sinistra e null.
        int? numeroPartecipanti = null;
        int partecipantiEffettivi = numeroPartecipanti ?? 0;
        Console.WriteLine($"Partecipanti: {partecipantiEffettivi}");

        // Anche i tipi riferimento possono essere annotati con ? quando i nullable reference types
        // sono abilitati nel progetto. string? comunica al compilatore che null e previsto.
        string? soprannome = null;

        // ?. esegue l'operazione soltanto se l'oggetto non e null; in caso contrario restituisce null.
        // Combinandolo con ?? evitiamo una NullReferenceException e mostriamo un testo alternativo.
        int lunghezzaSoprannome = soprannome?.Length ?? 0;
        Console.WriteLine($"Lunghezza del soprannome: {lunghezzaSoprannome}");

        // Esempio pratico: TryParse assegna il numero se la conversione riesce;
        // in caso contrario conserviamo null per indicare che non e stata fornita un'eta valida.
        Console.Write("Inserisci la tua eta (oppure premi Invio): ");
        string? input = Console.ReadLine();
        int? etaUtente = int.TryParse(input, out int etaValida) ? etaValida : null;

        string messaggio = etaUtente is int valore
            ? $"Hai inserito {valore} anni."
            : "Eta non specificata o non valida.";

        Console.WriteLine(messaggio);
    }
}
