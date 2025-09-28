namespace ProgettiExtraApp;

public static class Program
{
    public static void Main(string[] args)
    {
        Rubrica rubrica = new Rubrica();

        Contatto contatto = new Contatto("Mario Rossi", "mario.rossi@gmai.com", "340");
        rubrica.OnContattoAggiunto += OnContattoAggiunto;

        Console.WriteLine("Pre aggiunta");
        rubrica.AggiungiContatto(contatto);
        Console.WriteLine("Post aggiunta");
    }

    private static void OnContattoAggiunto(Contatto contatto)
    {
        Console.WriteLine($"Contatto aggiunto: {contatto}, dalla classe Program funzione Main");
    }
}
