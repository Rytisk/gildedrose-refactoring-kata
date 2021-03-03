using GildedRoseKata.Items;
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

            var item = new DexterityVestItem(sellIn, quality);

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

            var item = new DexterityVestItem(sellIn, quality);

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

            var item = new DexterityVestItem(sellIn, quality);

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

            var item = new DexterityVestItem(sellIn, quality);

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(quality, item.Quality);
        }

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

        [Theory]
        [InlineData("Aged Brie")]
        [InlineData("Backstage passes to a TAFKAL80ETC concert")]
        public void ShouldNotIncreaseQualityAboveMaximum(string name)
        {
            // arrange
            var maximumQuality = 50;
            var sellIn = 10;

            var item = new Item
            {
                Name = name,
                SellIn = sellIn,
                Quality = maximumQuality
            };

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(maximumQuality, item.Quality);
        }

        [Fact]
        public void ShouldNotDegradeSulfurasQuality()
        {
            // arrange
            var quality = 80;
            var sellIn = 10;

            var item = new SulfurasItem(sellIn, quality);

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(quality, item.Quality);
        }

        [Fact]
        public void ShouldNotAlterSulfurasSellInTime()
        {
            // arrange
            var quality = 80;
            var sellIn = 10;

            var item = new SulfurasItem(sellIn, quality);

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(sellIn, item.SellIn);
        }

        [Theory]
        [InlineData(11, 0, 1)]
        [InlineData(10, 0, 2)]
        [InlineData(5, 0, 3)]
        public void ShouldIncreaseBackstagePassQuality(int sellIn, int quality, int expectedQuality)
        {
            // arrange
            var item = new BackstagePassItem(sellIn, quality);

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

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

            var gildedRose = new GildedRose(new[] { item });

            // act
            gildedRose.UpdateQuality();

            // assert
            Assert.Equal(expectedQuality, item.Quality);
        }
    }
}