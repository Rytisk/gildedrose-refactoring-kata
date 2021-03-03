namespace GildedRoseKata.Items
{
    public class ConjuredManaCakeItem : DegradingItem
    {
        public ConjuredManaCakeItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Conjured Mana Cake";
        }
    }
}
