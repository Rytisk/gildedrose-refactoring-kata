using System;
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

            foreach (var item in _items)
            {
                if (item is IUpdatable updatableItem)
                {
                    updatableItem.Update();
                }
                else
                {
                    throw new ArgumentException(
                        $"Unable to update item '{item.Name}': " +
                        $"item does not implement {nameof(IUpdatable)} interface.");
                }
            }
        }
    }
}
