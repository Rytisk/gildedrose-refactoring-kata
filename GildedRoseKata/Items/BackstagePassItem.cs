namespace GildedRoseKata.Items
{
    public class BackstagePassItem : Item, IUpdatable
    {
        public BackstagePassItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
