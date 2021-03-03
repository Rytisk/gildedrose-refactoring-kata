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
            throw new System.NotImplementedException();
        }
    }
}
