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
            UpdateQuality();

            SellIn -= 1;

            ResetQualityWhenExpired();
        }

        private void UpdateQuality()
        {
            if (SellIn < 6)
            {
                IncreaseQualityBy(3);
            }
            else if (SellIn < 11)
            {
                IncreaseQualityBy(2);
            }
            else
            {
                IncreaseQualityBy(1);
            }
        }

        private void IncreaseQualityBy(int value)
        {
            var increasedQuality = Quality + value;

            Quality = increasedQuality > MaximumQuality
                ? MaximumQuality
                : increasedQuality;
        }

        private void ResetQualityWhenExpired()
        {
            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}
