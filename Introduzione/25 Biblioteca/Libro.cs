public class Libro
{
    private string? _isbn;
    private string? _titolo;
    private string? _autore;
    private int _annoPubblicazione;
    private int _disponibilita;

    public Libro(string? isbn, string titolo, string autore, int annoPubblicazione, int disponibilita)
    {
        _isbn = isbn;
        _titolo = titolo;
        _autore = autore;
        _annoPubblicazione = annoPubblicazione;
        _disponibilita = disponibilita;
    }

    //
    public string? GetISBN() => _isbn;
    public string? GetTitolo() => _titolo;
    public string? GetAutore() => _autore;
    public int GetAnnoPubblicazione() => _annoPubblicazione;
    public int GetDisponibilita() => _disponibilita;
    public void SetDisponibilita(int disponibilita) => _disponibilita = disponibilita;

    //
    public override string ToString()
    {
        return $"ISBN: {GetISBN()}, Titolo: {GetTitolo()}, Autore: {GetAutore()}, Anno Pubblicazione: {GetAnnoPubblicazione()}, Disponibilità: {GetDisponibilita()}";
    }
}