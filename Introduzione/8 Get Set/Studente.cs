public class Studente
{
    private string _name;
    private int _eta;
    private double _mediaVoti;

    //
    public string Nome => _name;
    public int Eta { get; set; }
    public double MediaVoti 
    { 
        get
        {
            return _mediaVoti;
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