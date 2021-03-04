using static GildedRoseKata.Constants.ItemConstants;

namespace GildedRoseKata.Items
{
    public class AgedBrieItem : Item, IUpdatable
    {
        public AgedBrieItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Aged Brie";
        }

        public void Update()
        {
            if (Quality < MaximumQuality)
            {
                Quality += 1;
            }

            SellIn -= 1;

            if (SellIn < 0 && Quality < MaximumQuality)
            {
                Quality += 1;
            }
        }
    }
}
