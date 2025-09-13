public class Audio : ElementoRiproducibile
{
    private int _volume;
    private int _volumeMin;
    private int _volumeMax;

    public Audio(string? _titolo, int durata, int volume, int volumeMin, int volumeMax) : base(_titolo, durata)
    {
        _volumeMin = volumeMin;
        _volumeMax = volumeMax;
        SetVolume(volume);
    }

    public override bool Riproducibile()
    {
        return GetDurata() > 0;
    }

    public override void Riproduci()
    {
        Console.WriteLine($"Riproduco l'audio {GetTitolo()} a volume {GetVolume()}");
    }

    public void SetVolume(int volume)
    {
        _volume = volume;
        if (_volume > _volumeMax)
            _volume = _volumeMax;
        if (_volume < _volumeMin)
            _volume = _volumeMin;
    }

    public int GetVolume() => _volume;
    public int GetVolumeMin() => _volumeMin;
    public int GetVolumeMax() => _volumeMax;

    public void AumentaVolume(int quantita)
    {
        SetVolume(_volume + quantita);
    }

    public void AbbassaVolume(int quantita)
    {
        SetVolume(_volume + quantita);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Volume: {GetVolume()}, Luminosita Min: {_volumeMin}, Luminosita Max: {_volumeMax}";
    }
}