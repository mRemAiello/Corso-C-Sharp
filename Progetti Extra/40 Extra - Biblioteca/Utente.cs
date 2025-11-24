namespace ProgettiExtra.Biblioteca;

public class Utente
{
    private int _id;

    //
    public Utente(int id)
    {
        _id = id;
    }

    //
    public int GetID() => _id;
    public virtual Permessi GetPermessi() => Permessi.Nessuno;

    //
    public override string ToString()
    {
        string ret = $"ID: {_id}, Permessi: ";
        foreach (Permessi permesso in Enum.GetValues(typeof(Permessi)))
        {
            if (GetPermessi().HasFlag(permesso))
            {
                ret += $"{permesso}, ";
            }
        }
        return ret;
    }
}