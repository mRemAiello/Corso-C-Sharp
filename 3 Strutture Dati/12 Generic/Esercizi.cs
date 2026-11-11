/*

Esercizio 1 — Gestione di un magazzino
Livello 1 · Molto facile

Un negozio di elettronica deve gestire diversi tipi di prodotti, come smartphone, computer e accessori.

Crea una classe generica Contenitore<T> che permetta di memorizzare un singolo elemento di qualsiasi tipo.

La classe deve consentire di inserire un elemento, recuperarlo e verificare se il contenitore è vuoto.

Nel programma principale, utilizza la classe per gestire un prodotto rappresentato da una stringa, un prezzo rappresentato da un decimal e una quantità rappresentata da un int.


Esercizio 2 — Sistema di notifiche
Livello 2 · Facile

Un'applicazione di consegne a domicilio deve inviare notifiche di diverso tipo ai propri utenti.

Crea una classe generica Notifica<T> che contenga un destinatario, un messaggio di tipo T e la data di creazione.

Implementa un metodo che restituisca il contenuto della notifica.

Il sistema deve poter gestire notifiche testuali, codici numerici di verifica e oggetti contenenti informazioni su una consegna.


Esercizio 3 — Gestione degli ordini di un e-commerce
Livello 3 · Facile

Un e-commerce vende prodotti appartenenti a categorie differenti.

Crea una classe generica Ordine<T> che permetta di memorizzare una collezione di articoli di tipo T.

Implementa le funzionalità per aggiungere un articolo, rimuoverlo, recuperare tutti gli articoli e ottenere il numero totale degli elementi presenti.

Verifica il funzionamento creando ordini contenenti libri, dispositivi elettronici e prodotti alimentari, rappresentati attraverso classi differenti.


Esercizio 4 — Archivio dei dipendenti
Livello 4 · Intermedio

Un'azienda vuole sviluppare un archivio per gestire dipendenti, collaboratori e consulenti esterni.

Tutte queste figure possiedono un identificativo numerico univoco.

Crea un'interfaccia IIdentificabile che esponga la proprietà Id.

Successivamente, sviluppa una classe generica Archivio<T> che accetti esclusivamente oggetti che implementano IIdentificabile.

L'archivio deve consentire di registrare una persona, cercarla tramite identificativo, eliminarla e impedire l'inserimento di identificativi duplicati.


Esercizio 5 — Sistema di prenotazioni
Livello 5 · Intermedio

Una piattaforma turistica gestisce prenotazioni per hotel, ristoranti e attività ricreative.

Ogni prenotazione possiede un codice identificativo, una data e uno stato.

Crea una classe base Prenotazione e alcune classi derivate che rappresentino i diversi servizi.

Implementa una classe generica GestorePrenotazioni<T> che accetti esclusivamente tipi derivati da Prenotazione.

Il gestore deve permettere di aggiungere prenotazioni, annullarle, cercarle tramite codice e ottenere soltanto quelle ancora attive.


Esercizio 6 — Elaborazione dei pagamenti
Livello 6 · Intermedio avanzato

Una piattaforma di vendita online supporta diversi metodi di pagamento: carta di credito, bonifico bancario e portafoglio digitale.

Crea un'interfaccia generica IProcessorePagamento<T> che definisca un metodo per elaborare un pagamento di tipo T.

Ogni metodo di pagamento deve possedere informazioni specifiche e una propria implementazione del processore.

Sviluppa un sistema che consenta di elaborare pagamenti differenti mantenendo la sicurezza dei tipi, senza utilizzare object o conversioni esplicite.



Esercizio 10 — Motore di elaborazione delle transazioni bancarie
Livello 10 · Esperto

Una banca digitale deve elaborare diverse tipologie di transazioni, come bonifici, prelievi, depositi e pagamenti ricorrenti.

Ogni transazione richiede validazioni specifiche, un processo di esecuzione e la produzione di un risultato.

Progetta un'architettura generica basata su un'interfaccia ITransactionHandler<TTransaction, TResult>.

Ogni handler deve accettare una particolare tipologia di transazione e restituire un risultato fortemente tipizzato.

Implementa una pipeline generica che consenta di eseguire, nell'ordine, la validazione della transazione, il controllo dei limiti operativi, l'esecuzione e la registrazione dell'esito.

La pipeline deve supportare componenti riutilizzabili, gestione asincrona tramite Task<TResult>, propagazione degli errori e annullamento delle operazioni tramite CancellationToken.

L'obiettivo è realizzare un'architettura estendibile che permetta di introdurre nuovi tipi di transazioni senza modificare il codice dei processori esistenti e senza ricorrere a dynamic, object o cast non sicuri.





Esercizio 1
• Implementare in C# una classe generica CoppiaMista<A,B> per gestire una coppia ordinata di
oggetti, che possono essere anche di tipo diverso
• La classe espone i seguenti metodi:
• Costruttore: prende in input i due oggetti
• getPrimo(), getSecondo(): ritornano rispettivamente i due
oggetti
• checkOmogenei(): ritorna true se i due oggetti sono dello
stesso tipo (istanze della stessa classe), false altrimenti


Esercizio 2
• Implementare in C# una classe generica per gestire una coppia di oggetti (anche di tipo diverso) colorati
• La classe espone i seguenti metodi:
• Costruttore: prende in input i due oggetti
• coloraTutti(Color c): setta il colore di tutti gli oggetti a c
• Come imporre che gli oggetti siano colorabili?
• Definire altre classi (o enumerazioni) e interfacce utili per
completare l’esercizio


Lista Personalizzata

Create a generic data structure that can store any type that can be compared. Implement functions:

    void Add(T element)
    T Remove(int index)
    bool Contains(T element)
    void Swap(int index1, int index2)
    int CountGreaterThan(T element)
    T Max()
    T Min()



https://github.com/RAstardzhiev/Software-University-SoftUni/blob/master/C%23%20OOP%20Advanced/Generics%20-%20Exercise/08.%20Custom%20List/Models/MyList.cs



*/