/*

Create a C# program that implements an IVehiculo interface with two methods, one for Drive of type void and 
another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel. 
Then create a Car class with a builder that receives a parameter with the car's starting 
gasoline amount and implements the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, 
if the gasoline is greater than 0. The Refuel method will increase the gasoline of the car and return true.

To carry out the tests, create an object of type Car with 0 of gasoline in the Main of 
the program and ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car. 

-------------------


Esercizio 1: Creazione di una Classe Base

Crea una classe chiamata Veicolo con le seguenti proprietà: Marca, Modello, AnnoDiProduzione e VelocitàMassima. 
Aggiungi un metodo chiamato Descrizione che restituisca una stringa con le informazioni del veicolo. 
Crea un'istanza della classe e stampa la descrizione del veicolo.


Esercizio 2: Sottoclasse con Metodi Sovrascritti

Crea una sottoclasse di Veicolo chiamata AutoElettrica che aggiunga una proprietà AutonomiaBatteria. 
Sovrascrivi il metodo Descrizione per includere l'autonomia della batteria. Crea un'istanza della sottoclasse e 
utilizza il metodo Descrizione per mostrare i dettagli.


Esercizio 3: Utilizzo di un'Interfaccia

Crea un'interfaccia chiamata IRicaricabile che definisca un metodo Ricarica(). Implementa questa interfaccia nella 
classe AutoElettrica e fai in modo che il metodo Ricarica() stampi un messaggio che indica che la batteria è in ricarica.


Esercizio 4: Ereditarietà Multipla con Interfacce

Crea un'interfaccia chiamata IVolante con un metodo Decolla(). Poi, crea una classe Aereo che 
erediti dalla classe Veicolo e implementi sia IRicaricabile che IVolante. Definisci i metodi richiesti e crea un’istanza di Aereo, 
utilizzando i metodi implementati.


Esercizio 5: Polimorfismo con Interfacce

Crea un elenco di oggetti di tipo IRicaricabile che contenga sia istanze di AutoElettrica che di Aereo. Usa un 
ciclo per chiamare il metodo Ricarica() su ogni elemento dell’elenco e osserva come viene eseguito per oggetti di classi diverse.


*/



/*


1. IComparable<T>

    Esercizio: Crea una classe Studente che abbia proprietà come Nome e MediaVoti. 
    Implementa l'interfaccia IComparable<Studente> per permettere l'ordinamento di una lista di studenti in base alla loro MediaVoti. 
    Ordina quindi una lista di oggetti Studente.

2. IEnumerable<T>

    Esercizio: Crea una classe Libreria che contenga un elenco di libri (rappresentati da stringhe). 
    Implementa l'interfaccia IEnumerable<string> per consentire l'iterazione dei libri all'interno della tua classe Libreria utilizzando un ciclo foreach.

3. ICollection<T>

    Esercizio: Crea una classe Inventario che implementi l'interfaccia ICollection<string>. 
    La classe dovrebbe permettere di aggiungere, rimuovere e contare gli elementi nell'inventario. 
    Gestisci anche la possibilità di verificare se un elemento esiste già nell'inventario.

4. IDisposable

    Esercizio: Crea una classe ConnessioneDatabase che implementa l'interfaccia IDisposable. 
    La classe dovrebbe simulare l'apertura e la chiusura di una connessione a un database. 
    Assicurati che la connessione venga chiusa automaticamente al termine dell'utilizzo della classe.

5. IEquatable<T>

    Esercizio: Crea una classe Libro che contenga proprietà come Titolo e Autore. 
    Implementa l'interfaccia IEquatable<Libro> per confrontare due oggetti Libro e determinare se rappresentano lo stesso libro. 
    Scrivi un programma che utilizza una lista di libri e verifica se un determinato libro è già presente nella lista.

6. ICloneable

    Esercizio: Crea una classe Auto con proprietà come Marca e Modello. 
    Implementa l'interfaccia ICloneable per permettere la creazione di una copia dell'oggetto Auto. 
    Successivamente, crea un oggetto Auto e genera una sua copia, dimostrando che i due oggetti sono separati ma identici.

7. IObservable<T> e IObserver<T>

    Esercizio: Crea una classe SensoreTemperatura che implementi l'interfaccia IObservable<int>, 
    la quale notifica i cambiamenti di temperatura ai suoi osservatori. Crea anche una classe Display che implementi l'interfaccia IObserver<int>, 
    in modo che il display possa ricevere notifiche e visualizzare la temperatura corrente ogni volta che cambia.


    */