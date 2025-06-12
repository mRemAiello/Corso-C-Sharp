public class Immagine : ElementoMultimediale
{
    private int _luminosita;
    private int _luminositaMin = 1;
    private int _luminositaMax = 100;

    public Immagine(string? titolo, int luminosita, int luminositaMin, int luminositaMax) : base(titolo)
    {
        _luminositaMin = luminositaMin;
        _luminositaMax = luminositaMax;
        SetLuminosita(luminosita);
    }

    public void Mostra()
    {
        Console.WriteLine($"Mostro l'immagine chiamata {GetTitolo()} con luminosita {GetLuminosita()}");
    }

    public int GetLuminosita() => _luminosita;
    public int GetLuminositaMin() => _luminositaMin;
    public int GetLuminositaMax() => _luminositaMax;

    public void SetLuminosita(int luminosita)
    {
        _luminosita = luminosita;
        if (_luminosita > _luminositaMax)
            _luminosita = _luminositaMax;
        if (_luminosita < _luminositaMin)
            _luminosita = _luminositaMin;
    }

    public void AumentaLuminosita(int quantita)
    {
        SetLuminosita(_luminosita + quantita);
    }

    public void DiminuisciLuminosita(int quantita)
    {
        SetLuminosita(_luminosita - quantita);
    }

    public override string ToString()
    {
        // Cosa restituirà? Qualcosa tipo:
        // Rock of Ages, Luminosita 2, Luminosita Min: 0, Luminosita Max: 100
        return $"{base.ToString()}, Luminosita: {GetLuminosita()}, Luminosita Min: {_luminositaMin}, Luminosita Max: {_luminositaMax}";
    }
}