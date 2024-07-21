using System.Diagnostics.Tracing;

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
        bool passwordCorretta = false;

        if (haAccount && haEmailVerificata)
        {
            Console.WriteLine("Accesso consentito.");
        }
        else if (!passwordCorretta)
        {
            Console.WriteLine("La password che hai scritto è sbagliata.");
        }
        else if (haAccount)
        {
            Console.WriteLine("Verifica l'email per accedere.");
        }
        else
        {
            Console.WriteLine("Registrati per creare un account.");
        }


        // If ternario prima del suo utilizzo
        int valore = 10;
        if (haAccount)
        {
            valore = 20;
        }
        else
        {
            valore = 30;
        }


        // If ternario in azione
        valore = (haAccount) ? 20 : 30;


        // If ternario
        età = 20;
        string stato = (età >= 18) ? "Maggiorenne" : "Minorenne";
    }
}