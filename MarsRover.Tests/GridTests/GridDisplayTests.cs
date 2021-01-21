using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class GridDisplayTests
    {
        [Fact]
        public void GetGridAsString()
        {
            var grid = TestHelper.SetupGrid();
            var mockRover = new Mock<IRover>();
            var roverLocation = grid.Find(1,1);
            var obstacleLocation = grid.Find(2,2);
            obstacleLocation.SquareState = SquareState.Not_Empty;
            var gridView = new GridDisplay(grid, mockRover.Object);
            var expected = "\n🟥🟥🟥🟥\n🟥🟥🟥🟥\n🟥🌋🟥🟥\n⏩🟥🟥🟥";

            mockRover.Setup(x => x.CurrentFacingDirection).Returns(new FacingEast());
            mockRover.Setup(x => x.CurrentSquareLocation).Returns(roverLocation);
            
            var actual = gridView.GetGridString();

            Assert.Equal(expected, actual);
        }
    }
}