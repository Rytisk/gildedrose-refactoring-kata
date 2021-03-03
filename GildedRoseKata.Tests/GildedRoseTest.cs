using System.Collections.Generic;
using Xunit;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTest
    {
        [Fact]
        public void ShouldDecreaseSellInTimeAfterEachUpdate()
        {
            // arrange
            var sellIn = 10;
            var quality = 20;

            var item = new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality };

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(sellIn - 1, item.SellIn);
        }

        [Fact]
        public void ShouldDegradeItemQualityAfterEachUpdate()
        {
            // arrange
            var sellIn = 10;
            var quality = 20;

            var item = new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality };

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(quality - 1, item.Quality);
        }

        [Fact]
        public void ShouldDegradeItemQualityTwiceAsFastAfterSellIn()
        {
            // arrange
            var sellIn = 0;
            var quality = 20;

            var item = new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality };

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(quality - 2, item.Quality);
        }

        [Fact]
        public void ShouldNotDegradeQualityBelowZero()
        {
            // arrange
            var sellIn = 10;
            var quality = 0;

            var item = new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality };

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(quality, item.Quality);
        }
    }
}