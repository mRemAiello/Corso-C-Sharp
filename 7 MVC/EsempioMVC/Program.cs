using EsempioMVC.Controllers;
using EsempioMVC.Models;
using EsempioMVC.Views;

// Model: contiene i dati iniziali
Studente studente = new Studente(1, "Mario", "Rossi", 24);

// View: gestisce la visualizzazione
StudenteView view = new StudenteView();

// Controller: collega Model e View
StudenteController controller = new StudenteController(studente, view);

controller.MostraStudente();

controller.SetVoto(28);
controller.SetCognome("Verdi");
controller.MostraStudente();

controller.SetVoto(35); // voto non valido, verrà rifiutato
controller.MostraStudente();
