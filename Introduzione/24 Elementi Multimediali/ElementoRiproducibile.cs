public class ElementoRiproducibile : ElementoMultimediale
{
    private int _durata;

    public ElementoRiproducibile(string? titolo, int durata) : base(titolo)
    {
        SetDurata(durata);
    }

    public virtual bool Riproducibile()
    {
        return true;
    }

    public virtual void Riproduci()
    {
    }

    public void SetDurata(int durata)
    {
        if (durata <= 0)
        {
            Console.WriteLine("La durata non può negativa o zero");
            return;
        }

        //
        _durata = durata;
    }

    public int GetDurata()
    {
        return _durata;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Durata: {GetDurata()}";
    }
}