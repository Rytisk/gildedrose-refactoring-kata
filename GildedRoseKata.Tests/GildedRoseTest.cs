using Moq;
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
    }
}