public class EsempioEccezioneNumeri
{
    public void Launch()
    {
        int[] numeri = { 1, 2, 3 };

        try
        {
            Console.WriteLine(numeri[5]); // Questo genererà un'eccezione IndexOutOfRangeException
        }
        catch (Exception ex)
        {
            Console.WriteLine("Si è verificata un'eccezione generica: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Questo blocco viene eseguito sempre.");
        }

        //
        
    }
}