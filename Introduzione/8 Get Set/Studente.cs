public class Studente
{
    private int _id;
    private string _name;
    private int _eta;
    private double _mediaVoti;

    // Read-only
    public string Nome => _name;

    // Auto implementate
    public int Eta { get; set; }

    // Read-only
    public double MediaVoti 
    { 
        get
        {
            return _mediaVoti;
        }
    }

    // Write-only
    public int ID
    {
        set
        {
            _id = value;
        }
    }

    public Studente(string name, int eta, double mediaVoti)
    {
        _name = name;
        _eta = eta;
        _mediaVoti = mediaVoti;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Età: {Eta}, Media Voti: {MediaVoti}";
    }
}