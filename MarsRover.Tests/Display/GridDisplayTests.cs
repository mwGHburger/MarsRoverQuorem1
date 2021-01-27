using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class GridDisplayTests
    {
        [Fact]
        public void GetGridAsString()
        {
            var grid = new Grid(4,4);
            var mockRover = new Mock<IRover>();
            var roverLocation = grid.FindSquare(1,1);
            var obstacleLocation = grid.FindSquare(2,2);
            obstacleLocation.SquareState = SquareState.Not_Empty;
            var gridView = new GridDisplay(grid, mockRover.Object);
            var expected = "\n🟥🟥🟥🟥" +
                           "\n🟥🟥🟥🟥" +
                           "\n🟥🌋🟥🟥" +
                           "\n⏩🟥🟥🟥";

            mockRover.Setup(x => x.CurrentFacingDirection).Returns(new FacingEast());
            mockRover.Setup(x => x.CurrentSquareLocation).Returns(roverLocation);
            
            var actual = gridView.GetDisplayString();

            Assert.Equal(expected, actual);
        }
    }
}