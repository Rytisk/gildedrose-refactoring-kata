using GildedRoseKata.Items;
using Xunit;

namespace GildedRoseKata.Tests.Items
{
    public class DegradingItemTest
    {
        [Fact]
        public void ShouldDecreaseSellInTimeAfterEachUpdate()
        {
            // arrange
            var sellIn = 10;
            var quality = 20;

            var item = new DegradingItem
            {
                SellIn = sellIn,
                Quality = quality
            };

            // act
            item.Update();

            // assert
            Assert.Equal(sellIn - 1, item.SellIn);
        }

        [Fact]
        public void ShouldDegradeItemQualityAfterEachUpdate()
        {
            // arrange
            var sellIn = 10;
            var quality = 20;

            var item = new DegradingItem
            {
                SellIn = sellIn,
                Quality = quality
            };

            // act
            item.Update();

            // assert
            Assert.Equal(quality - 1, item.Quality);
        }

        [Fact]
        public void ShouldDegradeItemQualityTwiceAsFastAfterSellIn()
        {
            // arrange
            var sellIn = 0;
            var quality = 20;

            var item = new DegradingItem
            {
                SellIn = sellIn,
                Quality = quality
            };

            // act
            item.Update();

            // assert
            Assert.Equal(quality - 2, item.Quality);
        }

        [Fact]
        public void ShouldNotDegradeQualityBelowZero()
        {
            // arrange
            var sellIn = 10;
            var quality = 0;

            var item = new DegradingItem
            {
                SellIn = sellIn,
                Quality = quality
            };

            // act
            item.Update();

            // assert
            Assert.Equal(quality, item.Quality);
        }
    }
}
