public interface IBuyable
{
    bool CanBeBought { get; }

    int BuyPrice { get; }

    void Buy();
}

// Veicolo : IBuyable, Auto : Veicolo, ISellable, Moto, Camion, Autobus
// Penna : Oggetto, IBuyable, ISellable