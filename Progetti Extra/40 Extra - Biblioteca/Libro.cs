namespace ProgettiExtra.Biblioteca;

public class Libro : ICloneable
{
    private string _isbn;
    private string _titolo;
    private string _autore;
    private int _annoPubblicazione;
    private int _disponibilita;

    public Libro(string isbn, string titolo, string autore, int annoPubblicazione, int disponibilita)
    {
        _isbn = isbn.ToUpper();
        _titolo = titolo;
        _autore = autore;
        _annoPubblicazione = annoPubblicazione;
        _disponibilita = disponibilita;
    }

    //
    public string GetISBN() => _isbn.ToUpper();
    public string GetTitolo() => _titolo;
    public string GetAutore() => _autore;
    public int GetAnnoPubblicazione() => _annoPubblicazione;
    public int GetDisponibilita() => _disponibilita;
    public void SetDisponibilita(int disponibilita) => _disponibilita = disponibilita;
    public object Clone() => new Libro(GetISBN(), GetTitolo(), GetAutore(), GetAnnoPubblicazione(), GetDisponibilita());

    //
    public override string ToString()
    {
        return $"ISBN: {GetISBN()}, Titolo: {GetTitolo()}, Autore: {GetAutore()}, Anno Pubblicazione: {GetAnnoPubblicazione()}, Disponibilità: {GetDisponibilita()}";
    }
}