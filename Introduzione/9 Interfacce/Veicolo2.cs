public class Veicolo2 : Veicolo, ISellable, IBuyable
{
    private int _buyPrice = 0;
    private int _sellPrice = 0;

    public int BuyPrice => _buyPrice;
    public int SellPrice => _sellPrice;

    public void Buy()
    { 
    }

    public void Sell()
    {   
    }
}