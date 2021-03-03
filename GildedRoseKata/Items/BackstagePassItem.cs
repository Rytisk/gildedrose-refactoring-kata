namespace GildedRoseKata.Items
{
    public class BackstagePassItem : Item
    {
        public BackstagePassItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }
    }
}
