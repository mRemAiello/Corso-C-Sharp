public class DatabaseManager : GenericSingleton<DatabaseManager>
{
    // private Db _db;

    protected override void OnPostAwake()
    {
        // Eseguire qualcosa dopo la PRIMA istanziazione.
    }

    protected override void OnPostDestroy()
    {
        // Salvare le impostazioni
        // Disconnettersi dal db
    }

    public void Save()
    {

    }

    public void Connect()
    {

    }

    public void Load()
    {

    }
}