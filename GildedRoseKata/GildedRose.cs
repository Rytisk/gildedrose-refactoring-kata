using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
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
            foreach (var item in _items)
            {
                if (item.Name == "Aged Brie")
                {
                    UpdateAgedBrie(item);

                    continue;
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    UpdateBackstagePasses(item);

                    continue;
                }
                else if (item.Name == "Sulfuras, Hand of Ragnaros")
                {
                    continue;
                }
                else
                {
                    UpdateGeneralItems(item);
                }
                
            }
        }
    }
}
