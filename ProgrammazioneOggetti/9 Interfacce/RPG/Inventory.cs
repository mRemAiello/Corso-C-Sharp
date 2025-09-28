public class Inventory
{
    public Dictionary<string, Item>? allItems;

    /*public List<ISellable> GetAllSellableItems()
    {
        foreach (var item in allItems)
        {
            if (item.Value is ISellable sellableItem)
            {
                yield return sellableItem;
            }
        }
    }*/
}