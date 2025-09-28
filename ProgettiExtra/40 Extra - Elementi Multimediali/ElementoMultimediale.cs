public class ElementoMultimediale
{
    private string? _titolo;

    public ElementoMultimediale(string? titolo)
    {
        SetTitolo(titolo);
    }

    public void SetTitolo(string? titolo)
    {
        if (string.IsNullOrEmpty(titolo))
        {
            Console.WriteLine("Titolo non può essere vuoto.");
            return;
        }

        //
        _titolo = titolo;
    }

    public string? GetTitolo()
    {
        return _titolo;
    }

    public override string ToString()
    {
        return $"{GetTitolo()}";
    }
}