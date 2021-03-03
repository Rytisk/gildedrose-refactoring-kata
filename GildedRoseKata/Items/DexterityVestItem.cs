namespace GildedRoseKata.Items
{
    public class DexterityVestItem : Item, IUpdatable
    {
        public DexterityVestItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "+5 Dexterity Vest";
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
