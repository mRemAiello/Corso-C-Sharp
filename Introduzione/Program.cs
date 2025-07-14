class Program
{
    // Realizzare 3 classi Chiave (Le chiavi possono essere meccaniche, magnetiche e con microchip) con le seguenti caratteristiche :
    // descrizione, peso
    // Le chiavi magnetiche sono caratterizzate dall'ampiezza, le chiavi meccaniche da un numero di dentelli.
    // Sia le chiavi meccaniche che quelle magnetiche sono rappresentate dalla lunghezza.
    // Inoltre, esiste un'operazione di aggiornamento per le chiavi con microchip.
    // La chiave con microchip avrà un codice seriale (stringa), che verrà aggiornato dalla funzione sopra menzionata.
    // Inserire, per ogni classe, una funzione che printa in maniera ordinata tutte le informazioni sulle chiavi
    // Infine, inserire una funzione che verifica quale è la chiave più leggera
    // Ogni chiave dovrà avere un costruttore che prenda in input tutti i parametri sopracitati.

    static void Main(string[] args)
    {
        ChiaveMeccanica meccanica = new("Una chiave meccanica", 0.2f, 0.3f, 4);
        ChiaveMagnetica magnetica = new("Una chiave magnetica", 0.15f, 0.2f, 0.4f);
        ChiaveConMicrochip microchip = new("Una chiave", 0.1f, "FF2XX4");

        Chiave[] chiavi = [meccanica, magnetica, microchip];
        foreach (Chiave chiave in chiavi)
        {
            Console.WriteLine(chiave);
        }

        Chiave chiavePiuLeggera = chiavi[0];
        foreach (var chiave in chiavi)
        {
            if (chiave.GetPeso() < chiavePiuLeggera.GetPeso())
            {
                chiavePiuLeggera = chiave;
            }
        }

        chiavePiuLeggera.SetDescrizione("Questa è la più leggera");
        Console.WriteLine(chiavi[2]);
        Console.WriteLine(chiavePiuLeggera);
    }
}