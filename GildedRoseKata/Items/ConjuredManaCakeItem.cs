namespace GildedRoseKata.Items
{
    public class ConjuredManaCakeItem : Item, IUpdatable
    {
        public ConjuredManaCakeItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Conjured Mana Cake";
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
