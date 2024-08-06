using System;

[Flags]
enum PermessiAccesso
{
    Nessuno = 0,
    Lettura = 1,
    Scrittura = 2,
    Esecuzione = 4,
    Amministratore = 8
}

public class EnumFlags
{
    /*static void Main(string[] args)
    {
        // Esempio di un utente con permessi di Lettura, Scrittura ed Esecuzione
        PermessiAccesso permessiUtente = PermessiAccesso.Lettura | PermessiAccesso.Scrittura | PermessiAccesso.Esecuzione;
        StampaPermessi(permessiUtente);

        // Esempio di un utente con tutti i permessi (Amministratore)
        PermessiAccesso permessiAdmin = PermessiAccesso.Amministratore | PermessiAccesso.Lettura | PermessiAccesso.Scrittura | PermessiAccesso.Esecuzione;
        StampaPermessi(permessiAdmin);
    }*/

    static void StampaPermessi(PermessiAccesso permessi)
    {
        if (permessi == PermessiAccesso.Nessuno)
        {
            Console.WriteLine("Nessun permesso assegnato.");
            return;
        }

        Console.WriteLine("Permessi assegnati:");
        foreach (PermessiAccesso permesso in Enum.GetValues(typeof(PermessiAccesso)))
        {
            if (permesso != PermessiAccesso.Nessuno && permessi.HasFlag(permesso))
            {
                Console.WriteLine($"- {permesso}");
            }
        }
    }
}
