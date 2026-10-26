public delegate void ContactEventHandler(object sender, ContactEventArgs e);

public class ContactEventArgs : EventArgs
{
    public Contatto? Contatto;
}

public class Rubrica
{
    private Dictionary<string, Contatto> _contacts = new();

    //
    public event ContactEventHandler? OnContactAdded;
    public event ContactEventHandler? OnContactRemoved;

    //
    public IReadOnlyList<Contatto> ContactsAsList => _contacts.Values.ToList();
    public IReadOnlyDictionary<string, Contatto> ContactsAsDictionary => _contacts;

    //
    public Rubrica(List<Contatto> listaContatti)
    {
        foreach (var contatto in listaContatti)
        {
            _contacts[contatto.Nome + " " + contatto.Cognome] = contatto;
        }
    }

    public Rubrica()
    {
        _contacts = new();
    }

    public void AddContact(Contatto contatto)
    {
        if (contatto == null)
            return;

        //
        _contacts[contatto.Nome + " " + contatto.Cognome] = contatto;

        // Evento
        OnContactAdded?.Invoke(this, new ContactEventArgs { Contatto = contatto });
    }

    public void RemoveContact(string key)
    {
        if (!_contacts.ContainsKey(key))
            return;

        Contatto contatto = _contacts[key];
        _contacts.Remove(key);

        // Evento
        OnContactRemoved?.Invoke(this, new ContactEventArgs { Contatto = contatto });
    }
}

class Program
{
    static void Main(string[] args)
    {
        /*Rubrica rubrica = new Rubrica();
        FileManager manager = new FileManager();

        prenotazione.OnPrenotazioneAdded += manager.Save();

        manager.Save();
        
        // Contatto aggiunto -> Email, Notifica


        Contatto contatto = new Contatto("Mario", "Rossi", "34005");


        rubrica.AddContact(contatto);*/
    }
}