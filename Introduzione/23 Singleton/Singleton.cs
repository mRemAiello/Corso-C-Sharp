public class MyClass
{
    //..attributi membro di istanza....
    private static MyClass _instance = null;
    
    protected MyClass()
    {
        //...inizializzazione istanza...
    }
    
    public static MyClass Instance
    {
        get
        {
            if (_instance==null) 
                _instance=new MyClass();
            
            return _instance;
        }
    }

    //...eventuali metodi pubblici, privati e protetti di istanza....
}