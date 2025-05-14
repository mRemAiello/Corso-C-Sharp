
public class EsempioEccezione
{
    public void Launch()
    {
        try
        {
            // Codice che può causare un'eccezione
        }
        catch (EccezioneTipo e)
        {
            // Codice per gestire l'eccezione
        }
        finally
        {
            // Codice eseguito sempre, sia che l'eccezione si verifichi o meno
        }
    }
}

public class EccezioneTipo : Exception
{
    public EccezioneTipo()
    {
    }

    public EccezioneTipo(string? message) : base(message)
    {
    }

    public EccezioneTipo(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}