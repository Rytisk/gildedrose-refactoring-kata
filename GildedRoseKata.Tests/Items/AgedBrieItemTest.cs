using GildedRoseKata.Items;
using Xunit;

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

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

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

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(quality + 2, item.Quality);
        }

        [Fact]
        public void ShouldNotIncreaseQualityAboveMaximum()
        {
            // arrange
            var maximumQuality = 50;
            var sellIn = 10;

            var item = new AgedBrieItem(sellIn, maximumQuality);

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(maximumQuality, item.Quality);
        }
    }
}
