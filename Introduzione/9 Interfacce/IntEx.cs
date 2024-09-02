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