using Moq;
using System;
using Xunit;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTest
    {
        [Fact]
        public void ShouldCallUpdateOnItemIfImplementsIUpdatable()
        {
            // arrange
            var item = new Mock<Item>();
            var updatableItem = item.As<IUpdatable>();

            var gildedRose = new GildedRose(new[] { item.Object });
            // act
            gildedRose.UpdateQuality();

            // assert
            updatableItem.Verify(
                u => u.Update(),
                Times.Once());
        }

        [Fact]
        public void ShouldThrowIfNonUpdatableItem()
        {
            // arrange
            var unknownItem = new Item { Name = "Unkown", Quality = 10, SellIn = 20 };
            var expectedMessage = $"Unable to update item '{unknownItem.Name}': " +
                $"item does not implement {nameof(IUpdatable)} interface.";

            var gildedRose = new GildedRose(new[] { unknownItem });

            // act
            // assert
            var exception = Assert.Throws<ArgumentException>(
                () => gildedRose.UpdateQuality());

            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}