public class While
{
    public void Execute()
    {
        // While 
        int contatore = 0;
        while (contatore < 5)
        {
            Console.WriteLine("Iterazione: " + contatore);
            contatore++;
        }

        // Esempio con connessione
        // bool conn = Connection.Open();
        // int tentativi = 0;
        // while (conn == false)
        // {
        //     conn = Connection.Open();
        //     tentativi++;
        //     if (tentativi == 3)
        //     {
        //         Console.WriteLine("Connessione non riuscita");
        //         break;
        //     }
        //     Console.WriteLine("Connessione non riuscita");
        // }

        // Trasformo while in for
        for (contatore = 0; contatore < 5; contatore++)
        {
            Console.WriteLine("Iterazione: " + contatore);
        }

        // Do while
        int numero = 5;
        do
        {
            Console.WriteLine("Numero: " + numero);
            numero--;
        } 
        while (numero > 0);
    }
}