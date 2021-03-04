using GildedRoseKata.Items;
using Xunit;
using static GildedRoseKata.Constants.ItemConstants;

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

        [Theory]
        [InlineData(10, 50)]
        [InlineData(10, 49)]
        [InlineData(5, 50)]
        [InlineData(5, 49)]
        public void ShouldNotIncreaseQualityAboveMaximum(int sellIn, int quality)
        {
            // arrange
            var item = new BackstagePassItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(MaximumQuality, item.Quality);
        }
    }
}
