public class Studente
{
    private string _name;
    private int _eta;
    private double _mediaVoti;

    // studente.GetEta();
    // studente.SetEta(50);
    public int GetEta() => _eta;
    public void SetEta(int eta)
    {
        if (eta <= 0)
            return;
        if (eta > 100)
            return;
        _eta = eta;
    }

    // studente.Eta = 40;
    // Console.WriteLine(studente.Eta);
    public int Eta
    {
        get => _eta;
        set
        {
            if (value <= 0)
                return;
            if (value > 100)
                return;
            _eta = value;
        }
    }

    // Accorpato sotto
    private string _titolo = "Non Assegnato";
    public string GetTitolo() => _titolo;
    public void SetTitolo(string titolo) => _titolo = titolo;

    // studente.Titolo = "Professore";
    // Console.WriteLine(studente.Titolo);
    public string Titolo { get; set; } = "Non Assegnato";

    // studente.ID = 10; ERRORE!
    // Console.WriteLine(studente.ID);
    public int ID { get; private set; }

    // studente.MediaVoto = 10;
    // Console.WriteLine(studente.MediaVoto); // ERRORE!
    public int MediaVoto { private get; set; } = 0;

    public Studente(string name, int eta, double mediaVoti)
    {
        _name = name;
        _eta = eta;
        _mediaVoti = mediaVoti;

        // int id = IDManager.GetUniqueID();
        // ID = IDManager.GetUniqueID();
    }

    public void CreateNewID()
    {
        // ID = IDManager.GetUniqueID();
    }

    /*public override string ToString()
    {
        return $"Nome: {Nome}, Età: {Eta}, Media Voti: {MediaVoti}";
    }*/
}