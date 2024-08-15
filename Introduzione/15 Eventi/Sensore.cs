public class Sensore
{
    public delegate void NotificaHandler(string messaggio);

    class SensoreEvento
    {
        public event NotificaHandler? NotificaEvento;

        public void RilevaCambiamento()
        {
            Console.WriteLine("Sensore: rilevato cambiamento.");
            OnNotificaEvento("Cambio di stato rilevato.");
        }

        protected virtual void OnNotificaEvento(string messaggio)
        {
            NotificaEvento?.Invoke(messaggio);
        }
    }

    // Primo gestore dell'evento
    static void PrimoListener(string messaggio)
    {
        Console.WriteLine("Primo listener ha ricevuto: " + messaggio);
    }

    // Secondo gestore dell'evento
    static void SecondoListener(string messaggio)
    {
        Console.WriteLine("Secondo listener ha ricevuto: " + messaggio);
    }

    static void Main()
    {
        SensoreEvento sensore = new();

        // Aggiunta di due gestori all'evento
        sensore.NotificaEvento += PrimoListener;
        sensore.NotificaEvento += SecondoListener;

        // Simulazione del cambiamento
        sensore.RilevaCambiamento();
    }
}