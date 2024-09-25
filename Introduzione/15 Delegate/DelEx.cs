/*


Esercizio 6: Gestione di Contatti e File con Delegate

    Crea una classe Contatto con gli attributi Nome, Cognome e NumeroTelefono.
    
    Definisci un'interfaccia ISalvabileSuFile con i metodi SalvaSuFile e CaricaDaFile.
    
    Crea una classe Rubrica che contenga una lista di oggetti Contatto e implementi l'interfaccia ISalvabileSuFile.
        Il metodo SalvaSuFile deve salvare tutti i contatti della rubrica in un file.
        Il metodo CaricaDaFile deve caricare i contatti da un file e aggiungerli alla lista della rubrica.
    
    Definisci un delegate chiamato GestioneContattoDelegate che accetta un oggetto Contatto e restituisce void.
    
    Aggiungi nella classe Rubrica due metodi che utilizzano il delegate:
        AggiungiContatto: accetta un delegate GestioneContattoDelegate che viene utilizzato per aggiungere un contatto alla rubrica.
        RimuoviContatto: accetta un delegate GestioneContattoDelegate che viene utilizzato 
        per rimuovere un contatto dalla rubrica dato il suo numero di telefono.
    
    Crea un programma che permetta all'utente di:
        Aggiungere un nuovo contatto alla rubrica utilizzando il metodo AggiungiContatto con un delegate che definisce la logica di aggiunta.
        Rimuovere un contatto dalla rubrica utilizzando il metodo RimuoviContatto con un delegate che definisce la logica di rimozione.
        Salvare i contatti su file e caricarli da un file utilizzando i metodi definiti nell'interfaccia ISalvabileSuFile.



Esercizio 7: Sistema di Prenotazioni con Delegate

    Crea una classe Prenotazione con gli attributi ID, NomeCliente, DataPrenotazione e NumeroPersone.
    Definisci un delegate chiamato GestionePrenotazioneDelegate che accetta un oggetto Prenotazione come parametro e restituisce void.
    Definisci un'interfaccia IGestorePrenotazioni con i metodi AggiungiPrenotazione, RimuoviPrenotazione, SalvaPrenotazioniSuFile e CaricaPrenotazioniDaFile.
    Crea una classe Ristorante che contenga una lista di oggetti Prenotazione e implementi l'interfaccia IGestorePrenotazioni.
        Utilizza un delegate GestionePrenotazioneDelegate per gestire l'operazione di aggiunta e rimozione delle prenotazioni.
        Il metodo AggiungiPrenotazione deve accettare un GestionePrenotazioneDelegate e usarlo per aggiungere una prenotazione alla lista.
        Il metodo RimuoviPrenotazione deve accettare un GestionePrenotazioneDelegate e usarlo per rimuovere una prenotazione data l'ID.
        Il metodo SalvaPrenotazioniSuFile deve salvare tutte le prenotazioni in un file.
        Il metodo CaricaPrenotazioniDaFile deve caricare le prenotazioni da un file e aggiungerle alla lista.
    Crea un programma che permetta all'utente di:
        Aggiungere una prenotazione usando un delegate che esegue questa operazione.
        Rimuovere una prenotazione usando un delegate che esegue questa operazione.
        Salvare e caricare le prenotazioni su/da un file.

*/