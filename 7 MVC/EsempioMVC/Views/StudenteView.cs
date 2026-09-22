using EsempioMVC.Models;

namespace EsempioMVC.Views
{
    // View: si occupa solo della presentazione dei dati, non contiene logica applicativa
    public class StudenteView
    {
        public void MostraDettagli(Studente studente)
        {
            Console.WriteLine("----- Scheda Studente -----");
            Console.WriteLine($"ID:      {studente.Id}");
            Console.WriteLine($"Nome:    {studente.Nome}");
            Console.WriteLine($"Cognome: {studente.Cognome}");
            Console.WriteLine($"Voto:    {studente.Voto}");
            Console.WriteLine("----------------------------\n");
        }

        public void MostraMessaggio(string messaggio)
        {
            Console.WriteLine(messaggio);
        }
    }
}
