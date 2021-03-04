namespace GildedRoseKata.Items
{
    public class SulfurasItem : Item, IUpdatable
    {
        private const int SulfurasQuality = 80;

        public SulfurasItem(int sellIn)
        {
            SellIn = sellIn;
            Quality = SulfurasQuality;
            Name = "Sulfuras, Hand of Ragnaros";
        }

        public void Update()
        {
        }
    }
}
