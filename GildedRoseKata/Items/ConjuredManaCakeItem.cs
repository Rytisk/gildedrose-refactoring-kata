namespace GildedRoseKata.Items
{
    public class ConjuredManaCakeItem : Item, IUpdatable
    {
        public ConjuredManaCakeItem(int sellIn, int quality)
        {
            Name = "Conjured Mana Cake";
            SellIn = sellIn;
            Quality = quality;
        }

        public void Update()
        {
            DecreaseQualityBy(2);

            SellIn -= 1;

            if (SellIn < 0)
            {
                DecreaseQualityBy(2);
            }
        }

        private void DecreaseQualityBy(int value)
        {
            var decreasedValue = Quality - value;

            Quality = decreasedValue < 0 
                ? 0
                : decreasedValue;
        }
    }
}
