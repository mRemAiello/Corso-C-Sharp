using EsempioMVC.Models;
using EsempioMVC.Views;

namespace EsempioMVC.Controllers
{
    // Controller: fa da tramite tra Model e View, gestisce la logica applicativa
    public class StudenteController
    {
        private readonly Studente _model;
        private readonly IView _view;

        public StudenteController(Studente model, IView view)
        {
            _model = model;
            _view = view;
        }

        public void SetNome(string nome)
        {
            // TODO: Controllare il nome (es. non vuoto, solo lettere)
            if (string.IsNullOrWhiteSpace(nome))
            {
                _view.MostraMessaggio("Nome non valido: non può essere vuoto.");
                return;
            }

            // Se il controllo è passato, aggiorna il modello
            _model.Nome = nome;
        }

        public void SetCognome(string cognome)
        {
            // TODO: Controllare il cognome (es. non vuoto, solo lettere)
            if (string.IsNullOrWhiteSpace(cognome))
            {
                _view.MostraMessaggio("Cognome non valido: non può essere vuoto.");
                return;
            }

            // Se il controllo è passato, aggiorna il modello
            _model.Cognome = cognome;
        }

        public void SetVoto(int voto)
        {
            if (voto < 0 || voto > 30)
            {
                _view.MostraMessaggio("Voto non valido: deve essere compreso tra 0 e 30.");
                return;
            }

            _model.Voto = voto;
        }

        public void MostraStudente()
        {
            _view.MostraDettagli("Scheda Studente", _model.ToDictionary());
        }
    }
}
