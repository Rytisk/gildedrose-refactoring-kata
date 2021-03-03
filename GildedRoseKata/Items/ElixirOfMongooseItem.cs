namespace GildedRoseKata.Items
{
    public class ElixirOfMongooseItem : Item, IUpdatable
    {
        public ElixirOfMongooseItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Elixir of the Mongoose";
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
