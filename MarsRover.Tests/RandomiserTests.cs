using Xunit;

namespace MarsRover.Tests
{
    public class RandomiserTests
    {
        [Fact]
        public void GetRandomNumber_ShouldReturnRandomNumberWithinARange()
        {
            var randomiser = new Randomiser();
            var maximumNumber = 10;

            var actual = randomiser.GetRandomNumber(maximumNumber);

            Assert.InRange(actual, 1, maximumNumber);
        }
    }
}