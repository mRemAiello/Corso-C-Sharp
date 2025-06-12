public class Filmato : ElementoRiproducibile
{
    private Immagine _immagine;
    private Audio _audio;

    public Filmato(string? titolo, int durata, int volumeMin, int volumeMax, int luminositaMin, int luminositaMax) : base(titolo, durata)
    {
        _immagine = new Immagine(titolo, luminositaMin, luminositaMin, luminositaMax);
        _audio = new Audio(titolo, durata, volumeMin, volumeMin, volumeMax);
    }

    public override bool Riproducibile()
    {
        return GetDurata() > 0;
    }

    public override void Riproduci()
    {
        Console.WriteLine($"Sto riproducendo il filmato {GetTitolo()} a volume {GetVolume()} e luminosita {GetLuminosita()}");
    }

    public override string ToString()
    {
        string str = $"{base.ToString()}, Luminosita: {GetLuminosita()}, Luminosita Min: {GetLuminositaMin()}, Luminosita Max: {GetLuminositaMax()}, ";
        str += $"Volume: {GetVolume()}, Volume Min: {GetVolumeMin()}, Volume Max: {GetVolumeMax()}";
        return str;
    }

    public void SetVolume(int volume) => _audio.SetVolume(volume);
    public int GetVolume() => _audio.GetVolume();
    public int GetVolumeMin() => _audio.GetVolumeMin();
    public int GetVolumeMax() => _audio.GetVolumeMax();
    public void AumentaVolume(int quantita) => _audio.AumentaVolume(quantita);
    public void AbbassaVolume(int quantita) => _audio.AbbassaVolume(quantita);
    public int GetLuminosita() => _immagine.GetLuminosita();
    public int GetLuminositaMin() => _immagine.GetLuminositaMin();
    public int GetLuminositaMax() => _immagine.GetLuminositaMax();
    public void SetLuminosita(int luminosita) => _immagine.SetLuminosita(luminosita);
    public void AumentaLuminosita(int quantita) => _immagine.AumentaLuminosita(quantita);
    public void DiminuisciLuminosita(int quantita) => _immagine.DiminuisciLuminosita(quantita);
}