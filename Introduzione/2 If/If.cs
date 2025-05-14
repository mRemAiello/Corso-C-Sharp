using System.Diagnostics.Tracing;

public class If
{
    public void Execute()
    {
        // If
        int eta = 15;
        if (eta >= 18)
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

        if (!haAccount)
        {
            Console.WriteLine("Registrati per creare un account.");
        }
        else if (haAccount && !haEmailVerificata)
        {
            Console.WriteLine("Verifica l'email per accedere.");
        }
        else if (haAccount && haEmailVerificata && !passwordCorretta)
        {
            Console.WriteLine("La password che hai scritto è sbagliata.");
        }
        else
        {
            Console.WriteLine("Accesso consentito.");
        }

        // Metodo alternativo più leggibile
        if (haAccount)
        {
            if (haEmailVerificata)
            {
                if (passwordCorretta)
                {
                    Console.WriteLine("Accesso consentito.");
                }
                else
                {
                    Console.WriteLine("La password che hai scritto è sbagliata.");
                }
            }
            else
            {
                Console.WriteLine("Verifica l'email per accedere.");
            }
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
        eta = 20;
        string stato = (eta >= 18) ? "Sei maggiorenne." : "Non sei ancora maggiorenne.";
        Console.WriteLine(stato);
    }
}