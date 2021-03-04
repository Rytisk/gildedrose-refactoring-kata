using GildedRoseKata.Items;
using System;
using System.Collections.Generic;

namespace GildedRoseKata.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            //TODO: Should create items through factory.
            // The Factory method should validate that the invariants hold for the items
            // (e.g. shouldn't create an item with quality above 50 unless a special case)

            var items = new List<Item> {
                new DexterityVestItem(10, 20),
                new AgedBrieItem(2, 0),
                new ElixirOfMongooseItem(5, 7),
                new SulfurasItem(0),
                new SulfurasItem(-1),
                new BackstagePassItem(15, 20),
                new BackstagePassItem(10, 49),
                new BackstagePassItem(5, 49),
                // this conjured item does not work properly yet
                new ConjuredManaCakeItem(3, 6)
            };

            var gildedRose = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }
                Console.WriteLine("");
                gildedRose.UpdateQuality();
            }
        }
    }
}
