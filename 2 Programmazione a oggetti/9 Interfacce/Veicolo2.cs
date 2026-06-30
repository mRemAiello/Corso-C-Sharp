public class Veicolo2 : Veicolo, IVeicolo, ISellable, IBuyable
{
    private int _buyPrice = 0;
    private int _sellPrice = 0;

    public int BuyPrice => _buyPrice;
    public int SellPrice => _sellPrice;

    public bool CanBeBought => true;

    public void Buy()
    { 
    }

    public void Sell()
    {   
    }

    public void Accelera(int velocita)
    {
    }

    public void Frena(int velocita)
    {
    }

    // Vendita => SellPrice, BuyPrice, Buy, Sell
    // Libro : Venduto, Comprato
    // Auto : Veicolo, Venduta, Comprata

    // Esempio Videogioco RPG
    // Item => ID, Nome, Descrizione, ....
    // Arma : Item, IBuyable, ISellable, IDamage, IEquipable
    // Armatura : Item, IBuyable, ISellable, IDefense, IEquipable
    // Pozione : Item, IBuyable, ISellable, IConsumable(Use)
    // OggettoChiave : Item
    // Pepite : Item, ISellable

    // Oggetto -> OggettoVendibile -> OggettoAcquistabile -> OggettoEquipaggiabile -> Arma, Armatura, ArmaDistanza, Scudo
    // Oggetto -> OggettoVendibile -> OggettoAcquistabile -> OggettoEquipaggiabile -> Pozione
    // Magia acquistabile, non vendibile, e non è un oggetto
    // Magia -> OggettoAcquistabile -> new Magia(id, nome, descrizione, prezzoVendita)

    // Veicolo : IBuyable, ISellable

    // npc.Buy(pozione); => pozione.BuyPrice, pozione.Buy()

    // NPC -> Buy(IBuyable), Sell(ISellable)
    // Player -> Buy(IBuyable), Sell(ISellable), Equip(IEquipable), Use(IConsumable)
}