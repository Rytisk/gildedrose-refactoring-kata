using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class ElixirOfMongooseItem : Item
    {
        public ElixirOfMongooseItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Elixir of the Mongoose";
        }
    }
}
