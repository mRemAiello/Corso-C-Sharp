public class EsempioEccezioneNumeri
{
    public void Launch()
    {
        try
        {
            int[] numeri = { 1, 2, 3 };
            Console.WriteLine(numeri[5]); // Questo genererà un'eccezione IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Errore: Tentativo di accesso a un indice non valido.");
        }
        finally
        {
            Console.WriteLine("Questo blocco viene eseguito sempre.");
        }
    }
}