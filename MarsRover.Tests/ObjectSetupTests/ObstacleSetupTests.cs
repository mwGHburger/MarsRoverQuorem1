using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class ObstacleSetupTests
    {
        [Fact]
        public void Setup_ShouldPlaceObstaclesOntoGridBasedOnUserInput()
        {
            var mockGrid = new Mock<IGrid>();
            var mockUserInterface = new Mock<IUserInterface>();
            var obstacleSetup = new ObstacleSetup(mockGrid.Object);

            obstacleSetup.Setup(mockUserInterface.Object);

            mockUserInterface.Verify(x => x.Print(It.IsAny<string>()));
        }
    }
}