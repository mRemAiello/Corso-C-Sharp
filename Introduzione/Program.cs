class Program
{
    static void Main(string[] args)
    {
        Persona persona = new("Tizio", Sesso.Uomo, 30);
        Persona persona2 = new("Caio", Sesso.Uomo, 25);
        Persona persona3 = new("Lucia", Sesso.Donna, 20);

        CoppiaMista<Persona, Persona> coppiaMista = new(persona, persona2);
        CoppiaMista<Persona, Persona> coppiaMista2 = new(persona, persona3);

        Console.WriteLine(coppiaMista.Check());
        Console.WriteLine(coppiaMista2.Check());

        Console.WriteLine(coppiaMista.CheckSameFirst(persona3));

        Console.WriteLine(coppiaMista);
        Console.WriteLine(coppiaMista2);
    }
}