using GildedRoseKata.Items;
using Xunit;

namespace GildedRoseKata.Tests.Items
{
    public class SulfurasItemTest
    {
        [Fact]
        public void ShouldNotDegradeSulfurasQuality()
        {
            // arrange
            var quality = 80;
            var sellIn = 10;

            var item = new SulfurasItem(sellIn, quality);

            // act
            item.Update();

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

            // act
            item.Update();

            // assert
            Assert.Equal(sellIn, item.SellIn);
        }
    }
}
