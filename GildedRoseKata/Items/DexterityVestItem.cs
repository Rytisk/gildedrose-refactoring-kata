using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class DexterityVestItem : Item
    {
        public DexterityVestItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "+5 Dexterity Vest";
        }
    }
}
