namespace ProgettiExtra.Biblioteca;

public class Dipendente : Utente
{
    public Dipendente(int id) : base(id)
    {
    }

    //
    public override Permessi GetPermessi() => Permessi.Aggiungere | Permessi.Visualizzare | Permessi.Rimuovere | Permessi.Cerca;
} 