using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverSetupTests
    {
        [Fact]
        public void Setup_ShouldConfigureTheRoverCurrentSquareLocation()
        {
            var mockRover = new Mock<IRover>();
            var mockGrid = new Mock<IGrid>();
            var roverSetup = new RoverSetup(mockRover.Object, mockGrid.Object);

            roverSetup.Setup();

            mockRover.VerifySet(x => x.CurrentSquareLocation = It.IsAny<ISquare>());
        }
    }
}