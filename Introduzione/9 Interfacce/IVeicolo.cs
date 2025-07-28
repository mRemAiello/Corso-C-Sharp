public interface IVeicolo
{
    void Avvia();
    void Arresta();
    void Accelera(int velocita);
    void Frena(int velocita);
}

// Esempio di interfaccia di oggetto vendibile / acquistabile
public interface ISellable
{
    int SellPrice { get; }

    void Sell();
}

public interface IBuyable
{
    int BuyPrice { get; }

    void Buy();
}