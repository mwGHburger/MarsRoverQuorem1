using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverGPSTests
    {
        [Fact]
        public void GetLocationString_ShouldReturnString()
        {
            var mockRover = new Mock<IRover>();   
            var roverGPS = new RoverGPS(mockRover.Object);
            var expected = "Rover is currently at 1, 1 facing North";

            mockRover.Setup(x => x.CurrentSquareLocation).Returns(new Square(1,1));
            mockRover.Setup(x => x.CurrentFacingDirection).Returns(new FacingNorth());

            var actual = roverGPS.GetLocationString();

            Assert.Equal(expected, actual);
        }
    }
}