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
            var mockUserInterface = new Mock<IUserInterface>();
            var roverSetup = new RoverSetup(mockRover.Object, mockGrid.Object);

            roverSetup.Setup(mockUserInterface.Object);

            mockUserInterface.Verify(x => x.Print(It.IsAny<string>()));
            mockRover.VerifySet(x => x.CurrentSquareLocation = It.IsAny<ISquare>());
        }
    }
}