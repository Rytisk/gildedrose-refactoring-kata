namespace GildedRoseKata.Items
{
    public class SulfurasItem : Item, IUpdatable
    {
        public SulfurasItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Sulfuras, Hand of Ragnaros";
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
