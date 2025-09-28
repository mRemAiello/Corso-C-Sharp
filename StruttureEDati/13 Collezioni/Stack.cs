public class Stack
{
    public void Execute()
    {
        // Creazione di uno stack di stringhe per rappresentare le azioni dell'utente
        Stack<string> azioni = new Stack<string>();

        // Aggiunta di azioni allo stack
        azioni.Push("Digitato 'Ciao'");
        azioni.Push("Digitato ' '");
        azioni.Push("Digitato 'mondo'");
        azioni.Push("Premuto 'Invio'");

        // Simulazione di un'operazione di Undo (annulla l'ultima azione)
        Console.WriteLine("Ultima azione annullata: " + azioni.Pop());

        // Visualizzazione delle azioni rimanenti
        Console.WriteLine("Azioni rimanenti:");
        foreach (var azione in azioni)
        {
            Console.WriteLine(azione);
        }

        // Controllo dell'azione successiva senza rimuoverla
        Console.WriteLine("Prossima azione da annullare: " + azioni.Peek());
    }
}