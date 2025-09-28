public class Singleton
{
    //..attributi membro di istanza....
    private static Singleton? _instance = null;
    
    protected Singleton()
    {
        //...inizializzazione istanza...
    }
    
    public static Singleton Instance
    {
        get
        {
            if (_instance == null) 
                _instance = new Singleton();
            
            return _instance;
        }
    }

    //...eventuali metodi pubblici, privati e protetti di istanza....
}