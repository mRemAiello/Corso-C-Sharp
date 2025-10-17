public class Singleton
{
    //..attributi membro di istanza....
    private static Singleton? _instance = null;

    // Differenza tra static e non static
    // class Persona -> int eta;
    // Persona p1 = new Persona(); -> p1.eta = 20;
    // Persona p2 = new Persona(); -> p1.eta = 10;
    // In memoria, 2 istanze = 2 variabili eta

    // Mettendo static, se io istanzio 2 oggetti, avrò 1 sola variabile eta condivisa
    // class Persona -> static int eta;
    // Persona p1 = new Persona(); -> Persona.eta = 20;
    // Persona p2 = new Persona(); -> Persona.eta = 10;
    // Console.WriteLine(p1.eta); -> 10
    // Console.WriteLine(p2.eta); -> 10

    protected Singleton()
    {
        //...inizializzazione istanza...
    }

    // DatabaseManager database = new DatabaseManager();
    // Con il costruttore protetto, mi viene negato

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }

    // DatabaseManager db = new DatabaseManager(); -> errore
    // DatabaseManager.Instance -> ok

    //...eventuali metodi pubblici, privati e protetti di istanza....
}