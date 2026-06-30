public interface IVeicolo
{
    void Avvia();
    void Arresta();
    void Accelera(int velocita);
    void Frena(int velocita);
}

// Veicolo (prezzoVendita, prezzoAcquisto, Compra, Vendi) -> Auto -> AutoSportiva
// Veicolo -> Moto -> MotoSportiva

// Libro (prezzoVendita, prezzoAcquisto, Compra, Vendi)

// Program -> Acquista(Veicolo), Acquista(Libro)

// Esempio di interfaccia di oggetto vendibile / acquistabile