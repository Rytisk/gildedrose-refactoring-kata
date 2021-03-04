using static GildedRoseKata.Constants.ItemConstants;

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
            if (Quality < MaximumQuality)
            {
                Quality += 1;

                if (SellIn < 11 && Quality < MaximumQuality)
                {
                    Quality += 1;
                }

                if (SellIn < 6 && Quality < MaximumQuality)
                {
                    Quality += 1;
                }
            }

            SellIn -= 1;

            if (SellIn < 0)
            {
                Quality -= Quality;
            }
        }
    }
}
