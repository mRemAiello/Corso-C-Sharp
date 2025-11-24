namespace ProgettiExtra.Biblioteca;

public class Amministratore : Utente
{
    public Amministratore(int id) : base(id)
    {
    }

    //
    public override Permessi GetPermessi() => Permessi.Amministratore;
}