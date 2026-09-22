namespace EsempioMVC.Models
{
    // Model: rappresenta i dati e lo stato dell'applicazione
    public class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Voto { get; set; }

        public Studente(int id, string nome, string cognome, int voto)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            Voto = voto;
        }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>
            {
                { "ID", Id.ToString() },
                { "Nome", Nome },
                { "Cognome", Cognome },
                { "Voto", Voto.ToString() }
            };
        }
    }
}