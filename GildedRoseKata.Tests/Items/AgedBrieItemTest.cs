using GildedRoseKata.Items;
using Xunit;
using static GildedRoseKata.Constants.ItemConstants;

namespace GildedRoseKata.Tests.Items
{
    public class AgedBrieItemTest
    {
        [Fact]
        public void ShouldIncreaseAgedBrieQualityAfterEachUpdate()
        {
            // arrange
            var sellIn = 10;
            var quality = 10;

            var item = new AgedBrieItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(quality + 1, item.Quality);
        }

        [Fact]
        public void ShouldIncreaseAgedBrieQualityTwiceAsFastAfterSellIn()
        {
            // arrange
            var sellIn = 0;
            var quality = 10;

            var item = new AgedBrieItem(sellIn, quality);

            // act
            item.Update();

            // assert
            Assert.Equal(quality + 2, item.Quality);
        }

        [Fact]
        public void ShouldNotIncreaseQualityAboveMaximum()
        {
            // arrange
            var sellIn = 10;

            var item = new AgedBrieItem(sellIn, MaximumQuality);

            // act
            item.Update();

            // assert
            Assert.Equal(MaximumQuality, item.Quality);
        }
    }
}
