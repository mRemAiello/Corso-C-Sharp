public class SwitchEnum
{
    enum GiorniSettimana { Lunedì, Martedì, Mercoledì, Giovedì, Venerdì, Sabato, Domenica }

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
            // Aggiungere altri casi se necessario
            default:
                nomeGiorno = "Giorno non valido";
                break;
        }

        GiorniSettimana giornoEnum = GiorniSettimana.Martedì;
        string nomeGiornoEnum;

        switch (giornoEnum)
        {
            case GiorniSettimana.Lunedì:
                nomeGiornoEnum = "Lunedì";
                break;
            case GiorniSettimana.Martedì:
                nomeGiornoEnum = "Martedì";
                break;
            // Gestire gli altri giorni
            default:
                nomeGiornoEnum = "Giorno non valido";
                break;
        }
    }
}