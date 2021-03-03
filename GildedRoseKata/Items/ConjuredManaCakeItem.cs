using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class ConjuredManaCakeItem : Item
    {
        public ConjuredManaCakeItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Conjured Mana Cake";
        }
    }
}
