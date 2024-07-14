public class If
{
    public void Execute()
    {
        // If
        int età = 15;
        if (età >= 18)
        {
            Console.WriteLine("Sei maggiorenne.");
        }
        else
        {
            Console.WriteLine("Non sei ancora maggiorenne.");
        }


        //
        bool haAccount = true;
        bool haEmailVerificata = false;

        if (haAccount && haEmailVerificata)
        {
            Console.WriteLine("Accesso consentito.");
        }
        else if (haAccount)
        {
            Console.WriteLine("Verifica l'email per accedere.");
        }
        else
        {
            Console.WriteLine("Registrati per creare un account.");
        }


        // If ternario
        età = 20;
        string stato = (età >= 18) ? "Maggiorenne" : "Minorenne";
    }
}