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
            var sellIn = 10;

            var item = new SulfurasItem(sellIn);

            // act
            item.Update();

            // assert
            Assert.Equal(80, item.Quality);
        }

        [Fact]
        public void ShouldNotAlterSulfurasSellInTime()
        {
            // arrange
            var sellIn = 10;

            var item = new SulfurasItem(sellIn);

            // act
            item.Update();

            // assert
            Assert.Equal(sellIn, item.SellIn);
        }
    }
}
