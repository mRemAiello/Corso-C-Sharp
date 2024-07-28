public class SwitchEnum
{
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
        int giorno = 2;
        string nomeGiorno;

        switch (giorno)
        {
            case 1:
                nomeGiorno = "Lunedì";
                break;
            case 2:
                nomeGiorno = "Martedì";
                break;
            case 3:
                nomeGiorno = "Mercoledì";
                break;
            default:
                nomeGiorno = "Giorno non valido";
                break;
        }
        Console.WriteLine(nomeGiorno);

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