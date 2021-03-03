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

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                if (item is IUpdatable updatableItem)
                {
                    updatableItem.Update();
                }
                else
                {
                    // unknown types
                    UpdateGeneralItems(item);
                }
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
    }
}
