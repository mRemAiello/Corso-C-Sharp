using EsempioMVC.Controllers;
using EsempioMVC.Models;
using EsempioMVC.Views;

// Model: contiene i dati iniziali
Studente studente = new Studente(1, "Mario", "Rossi", 24);

// Model2: contiene eventuali altri dati o entità del sistema
Studente studente2 = new Studente(2, "Luigi", "Bianchi", 30);

// View: gestisce la visualizzazione
ConsoleView consoleView = new ConsoleView();
FileView fileView = new FileView();

// Controller: collega Model e View
StudenteController controller = new StudenteController(studente, consoleView);

controller.MostraStudente();

controller.SetVoto(28);
controller.SetCognome("Verdi");
controller.MostraStudente();

controller.SetVoto(35); // voto non valido, verrà rifiutato
controller.MostraStudente();

// Gestione del secondo studente
StudenteController controller2 = new StudenteController(studente2, fileView);
controller2.MostraStudente();

controller2.SetVoto(27);
controller2.SetCognome("Neri");
controller2.MostraStudente();

controller2.SetVoto(40); // voto non valido, verrà rifiutato
controller2.MostraStudente();