using GildedRoseKata.Items;
using Xunit;

namespace GildedRoseKata.Tests.Items
{
    public class ConjuredManaCakeItemTest
    {
        [Fact]
        public void ShouldDecreaseSellInTimeAfterEachUpdate()
        {
            // arrange
            var sellIn = 10;
            var quality = 20;

            var item = new ConjuredManaCakeItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(sellIn - 1, item.SellIn);
        }

        [Fact]
        public void ShouldDegradeItemQualityByTwoAfterEachUpdate()
        {
            // arrange
            var sellIn = 10;
            var quality = 20;

            var item = new ConjuredManaCakeItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(quality - 2, item.Quality);
        }

        [Fact]
        public void ShouldDegradeItemQualityTwiceAsFastAfterSellIn()
        {
            // arrange
            var sellIn = 0;
            var quality = 20;

            var item = new ConjuredManaCakeItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(quality - 4, item.Quality);
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(1, 0)]
        [InlineData(0, 0)]
        public void ShouldNotDegradeQualityBelowZero(int sellIn, int quality)
        {
            // arrange
            var item = new ConjuredManaCakeItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(0, item.Quality);
        }
    }
}
