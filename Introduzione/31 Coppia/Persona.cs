public enum Sesso
{
    Uomo,
    Donna,
    NonDefinito
}

public class Persona
{
    public string? Nome;
    public Sesso Sesso;
    public int Eta;

    public Persona(string? nome, Sesso sesso, int eta)
    {
        Nome = nome;
        Sesso = sesso;
        Eta = eta;
    }

    public override string ToString()
    {
        return $"{Nome} ({Sesso}) di anni {Eta}";
    }
}