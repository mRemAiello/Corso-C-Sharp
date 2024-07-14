public class While
{
    public void Execute()
    {
        int contatore = 0;

        while (contatore < 5)
        {
            Console.WriteLine("Iterazione: " + contatore);
            contatore++;
        }

        int numero = 5;

        do
        {
            Console.WriteLine("Numero: " + numero);
            numero--;
        } 
        while (numero > 0);
    }
}