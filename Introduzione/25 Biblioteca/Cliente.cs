public class Cliente : Utente
{
    public Cliente(int id) : base(id)
    {
    }

    //
    public override Permessi GetPermessi() => Permessi.Cerca | Permessi.Restituire | Permessi.Visualizzare | Permessi.Prestito;
}