public class SwitchEnum
{
    enum Operazioni
    {
        Aggiunta = 0,
        AggiuntaMultipla = 4,
        Rimozione = 1,
        RimozioneMultipla = 6,
        Visualizza = 2,
        Modifica = 5,
        Uscita = 3,
    }

    enum GiorniSettimana
    {
        Lunedì,
        Martedì,
        Mercoledì,
        Giovedì,
        Venerdì,
        Sabato,
        Domenica
    }

    public void Execute()
    {
        // Esempio di operazione con intero
        // int operazione = ....
        // if (operazione == 0)
        // 
        // Qui sotto con l'enum
        // Console.WriteLine("Quale operazione vuoi eseguire? (0: Aggiunta, 1: Rimozione, 2: Visualizza, 3: Uscita)");
        Operazioni operazione = Operazioni.Aggiunta;
        if (operazione == Operazioni.Aggiunta)
        {
            Console.WriteLine("Aggiunta");
        }
        else if (operazione == Operazioni.AggiuntaMultipla)
        {
            Console.WriteLine("Aggiunta multipla");
        }
        else if (operazione == Operazioni.Rimozione)
        {
            Console.WriteLine("Rimozione");
        }
        else if (operazione == Operazioni.Visualizza)
        {
            Console.WriteLine("Visualizza");
        }

        //
        switch (operazione)
        {
            case Operazioni.Aggiunta:
            case Operazioni.AggiuntaMultipla:
                Console.WriteLine("Aggiunta");
                break;

            case Operazioni.Rimozione:
                Console.WriteLine("Rimozione");
                break;

            case Operazioni.Visualizza:
                Console.WriteLine("Visualizza");
                break;
        }

        //
        string localizedString = "";
        GiorniSettimana giorno = GiorniSettimana.Mercoledì;
        localizedString = giorno switch
        {
            GiorniSettimana.Lunedì => "Lunedì",
            GiorniSettimana.Martedì => "Martedì",
            GiorniSettimana.Mercoledì => "Mercoledì",
            GiorniSettimana.Giovedì => "Giovedì",
            GiorniSettimana.Venerdì => "Venerdì",
            GiorniSettimana.Sabato => "Sabato",
            GiorniSettimana.Domenica => "Domenica",
            _ => "Giorno non valido",
        };
        Console.WriteLine(localizedString);

        //
        GiorniSettimana giornoEnum = GiorniSettimana.Martedì;
        string nomeGiornoEnum = giornoEnum switch
        {
            GiorniSettimana.Lunedì => "Lunedì",
            GiorniSettimana.Martedì => "Martedì",
            GiorniSettimana.Mercoledì => "Mercoledì",
            GiorniSettimana.Giovedì => "Giovedì",
            _ => "Giorno non valido",
        };
        Console.WriteLine(nomeGiornoEnum);
    }
}


// https://codegrind.it/esercizi/csharp/switch

// https://codegrind.it/esercizi/csharp/enum