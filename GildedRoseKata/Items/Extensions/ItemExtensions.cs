using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata.Items.Extensions
{
    public static class ItemExtensions
    {
        public static IUpdatable MapToUpdatable(this Item item)
        {
            if (item is IUpdatable updatable) return updatable;

            // More flexible way could be achieved using attributes
            return item.Name switch
            {
                "Aged Brie" => new AgedBrieItem(item.SellIn, item.Quality),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassItem(item.SellIn, item.Quality),
                "Sulfuras, Hand of Ragnaros" => new SulfurasItem(item.SellIn, item.Quality),
                _ => new DegradingItem(item.Name, item.SellIn, item.Quality)
            };
        }

        public static IList<IUpdatable> MapToUpdatable(this IList<Item> items) =>
            items.Select(i => i.MapToUpdatable()).ToList();
    }
}
