public interface IBuyable
{
    bool CanBeBought { get; }

    int BuyPrice { get; }

    void Buy();
}