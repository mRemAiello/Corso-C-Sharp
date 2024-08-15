public class Tuple
{
    public void Execute()
    {
        // Creazione di una tupla con tre elementi
        Tuple<string, int, bool> persona = new("Mario", 30, true);

        // Accesso agli elementi della tupla
        Console.WriteLine("Nome: " + persona.Item1);
        Console.WriteLine("Età: " + persona.Item2);
        Console.WriteLine("Iscrivito: " + persona.Item3);

        // Creazione di una tupla con sintassi più moderna
        var nuovaPersona = ("Luigi", 28, false);

        // Accesso agli elementi tramite nomi di proprietà
        Console.WriteLine("Nome: " + nuovaPersona.Item1);
        Console.WriteLine("Età: " + nuovaPersona.Item2);
        Console.WriteLine("Iscrivito: " + nuovaPersona.Item3);
    }
}