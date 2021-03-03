﻿namespace GildedRoseKata.Items
{
    public class DegradingItem : Item, IUpdatable
    {
        public virtual void Update()
        {
            if (Quality > 0)
            {
                Quality -= 1;
            }

            SellIn -= 1;

            if (SellIn < 0 && Quality > 0)
            {
                Quality -= 1;
            }
        }
    }
}