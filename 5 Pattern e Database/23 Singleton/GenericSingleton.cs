public class GenericSingleton<T> where T : GenericSingleton<T>, new()
{
    private static T? _instance = null;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
                Instance.OnPostAwake();
            }

            return _instance;
        }
    }

    protected GenericSingleton()
    {
    }

    // Distruttore
    ~GenericSingleton()
    {
        if (Instance == this)
        {
            _instance = null;
            OnPostDestroy();
        }
    }

    protected virtual void OnPostAwake() { }
    protected virtual void OnPostDestroy() { }
}