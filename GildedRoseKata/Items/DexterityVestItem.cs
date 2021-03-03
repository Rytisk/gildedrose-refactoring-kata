namespace GildedRoseKata.Items
{
    public class DexterityVestItem : DegradingItem
    {
        public DexterityVestItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "+5 Dexterity Vest";
        }
    }
}
