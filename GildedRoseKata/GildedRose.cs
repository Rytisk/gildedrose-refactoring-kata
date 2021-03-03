using GildedRoseKata.Items.Extensions;
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
            // Ideally people using this code, would pass all classes
            // implementing IUpdatable interface (can't enforce this atm because
            // not allowed to change Item class and _items field)

            // If not possible to enforce and change the calling code at all,
            // this should be a place to map Items them based on Name :(

            var updatableItems = _items.MapToUpdatable();

            foreach (var updatableItem in updatableItems)
            {
                updatableItem.Update();
            }
        }
    }
}
