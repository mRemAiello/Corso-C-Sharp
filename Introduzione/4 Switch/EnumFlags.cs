using System;

// Permessi con i bit
// Lettura, Scrittura, Esecuzione


// Con le enum
// Nessuno = 0 => 0
// Lettura = 1 => 1
// Scrittura = 2 => 11
// Lettura + Scrittura = 3 => 011
// Esecuzione = 4
// Lettura + Esecuzione = 5
// Scrittura + Esecuzione = 6
// Lettura + Scrittura + Esecuzione = 7
// Amministrazione = 8

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
    public void Execute()
    {
        // Esempio di un utente con permessi di Lettura
        PermessiAccesso permessiLettura = PermessiAccesso.Lettura;
        StampaPermessi(permessiLettura);

        // Esempio di un utente con permessi di Lettura, Scrittura ed Esecuzione
        PermessiAccesso permessiUtente = PermessiAccesso.Lettura | PermessiAccesso.Scrittura | PermessiAccesso.Esecuzione;
        StampaPermessi(permessiUtente);

        // Esempio di un utente con tutti i permessi (Amministratore)
        PermessiAccesso permessiAdmin = PermessiAccesso.Amministratore | PermessiAccesso.Lettura | PermessiAccesso.Scrittura | PermessiAccesso.Esecuzione;
        Console.WriteLine(permessiAdmin);
        StampaPermessi(permessiAdmin);

        // File X => Scrittura
        // Utente Y => Lettura
        // Enum.GetValues => new PermessiAccesso[] { }
    }

    static void StampaPermessi(PermessiAccesso permessi)
    {
        if (permessi == PermessiAccesso.Nessuno)
        {
            Console.WriteLine("Nessun permesso assegnato.");
            return;
        }

        Console.WriteLine("Permessi assegnati:");
        // typeof(PermessiAccesso) è un modo per ottenere il tipo enum
        // type(PermessiAccesso)
        // [PermessiAcessso.Nessuno, PermessiAccesso.Lettura, PermessiAccesso.Scrittura, PermessiAccesso.Esecuzione]
        // permesso => PermessiAccesso.Nessuno
        // permesso => PermessiAccesso.Lettura
        foreach (PermessiAccesso permesso in Enum.GetValues(typeof(PermessiAccesso)))
        {
            if (permesso != PermessiAccesso.Nessuno && permessi.HasFlag(permesso))
            {
                Console.WriteLine($"- {permesso}");
            }
        }
    }
}
