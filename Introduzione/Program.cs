using DelegateExample;

class Program
{
    static void Main(string[] args)
    {
        Rubrica rubrica = new Rubrica();
        //FileManager fileManager = new FileManager(rubrica);

        Contatto contatto = new Contatto("Mario Rossi", "mario.rossi@gmai.com", "340");
        rubrica.OnContattoAggiunto += OnContattoAggiunto;

        Console.WriteLine("Pre aggiunta");
        rubrica.AggiungiContatto(contatto);
        Console.WriteLine("Post aggiunta");
    }

    static void OnContattoAggiunto(Contatto contatto)
    {
        Console.WriteLine($"Contatto aggiunto: {contatto}, dalla classe Program funzione Main");
    }
}