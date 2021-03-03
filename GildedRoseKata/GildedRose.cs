using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private IList<Item> _items;

        public GildedRose(IList<Item> Items)
        {
            _items = Items;
        }

        private void UpdateAgedBrie(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }

            item.SellIn -= 1;

            if (item.SellIn < 0 && item.Quality < 50)
            {
                item.Quality += 1;
            }
        }

        private void UpdateBackstagePasses(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;

                if (item.SellIn < 11 && item.Quality < 50)
                {
                    item.Quality += 1;
                }

                if (item.SellIn < 6 && item.Quality < 50)
                {
                    item.Quality += 1;
                }
            }

            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                item.Quality -= item.Quality;
            }
        }

        private void UpdateGeneralItems(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 1;
            }

            item.SellIn -= 1;

            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality -= 1;
            }
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == "Aged Brie")
                {
                    UpdateAgedBrie(_items[i]);

                    continue;
                }
                else if (_items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    UpdateBackstagePasses(_items[i]);

                    continue;
                }
                else if (_items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                    continue;
                }
                else
                {
                    UpdateGeneralItems(_items[i]);
                }
                
            }
        }
    }
}
