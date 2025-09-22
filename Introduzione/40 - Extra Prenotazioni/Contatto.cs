public class Contatto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Contatto(string nome, string email, string telefono)
    {
        Nome = nome;
        Email = email;
        Telefono = telefono;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Email: {Email}, Telefono: {Telefono}";
    }
}