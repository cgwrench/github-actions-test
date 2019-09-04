using Xunit;

namespace SampleLibrary.Tests
{
    public class MathTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]
        public void Add_Returns_42(int x, int y)
        {
            // Arrange
            var sut = new Math();

            // Act
            var result = sut.Add(x, y);

            // Assert
            Assert.Equal(42, result);
        }
    }
}
