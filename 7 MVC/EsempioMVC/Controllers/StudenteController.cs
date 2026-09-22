using EsempioMVC.Models;
using EsempioMVC.Views;

namespace EsempioMVC.Controllers
{
    // Controller: fa da tramite tra Model e View, gestisce la logica applicativa
    public class StudenteController
    {
        private readonly Studente _model;
        private readonly StudenteView _view;

        public StudenteController(Studente model, StudenteView view)
        {
            _model = model;
            _view = view;
        }

        public void SetNome(string nome) => _model.Nome = nome;

        public void SetCognome(string cognome) => _model.Cognome = cognome;

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
            _view.MostraDettagli(_model);
        }
    }
}
