using GildedRoseKata.Items;
using Xunit;

namespace GildedRoseKata.Tests.Items
{
    public class BackstagePassItemTest
    {
        [Theory]
        [InlineData(11, 0, 1)]
        [InlineData(10, 0, 2)]
        [InlineData(5, 0, 3)]
        public void ShouldIncreaseBackstagePassQuality(int sellIn, int quality, int expectedQuality)
        {
            // arrange
            var item = new BackstagePassItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(expectedQuality, item.Quality);
        }

        [Theory]
        [InlineData(0, 10, 0)]
        [InlineData(-1, 10, 0)]
        public void ShouldResetBackstagePassQualityIfExpired(int sellIn, int quality, int expectedQuality)
        {
            // arrange
            var item = new BackstagePassItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(expectedQuality, item.Quality);
        }

        [Fact]
        public void ShouldNotIncreaseQualityAboveMaximum()
        {
            // arrange
            var maximumQuality = 50;
            var sellIn = 10;

            var item = new BackstagePassItem(sellIn, maximumQuality);

            // act
            item.Update();

            // assert
            Assert.Equal(maximumQuality, item.Quality);
        }
    }
}
