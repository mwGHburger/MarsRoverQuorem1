using Xunit;

namespace MarsRover.Tests
{
    public class FacingSouthTests
    {
        ICardinalDirection facingSouth = new FacingSouth();
        IGrid grid = new Grid(4,4);
        
        [Fact]
        public void GetLeftDirection_ShouldReturn_DirectionFacingNorth()
        {
            var actual = facingSouth.GetLeftDirection().Name;

            Assert.Equal(DirectionName.East, actual);
        }

        [Fact]
        public void GetRightDirection_ShouldReturn_DirectionFacingSouth()
        {
            var actual = facingSouth.GetRightDirection().Name;

            Assert.Equal(DirectionName.West, actual);
        }

        [Theory]
        [InlineData(1,1,4,1)]
        [InlineData(2,2,1,2)]
        public void GetSquareLocationInfront_ShouldReturn_SquareBelow(int startingRow, int startingColumn, int expectedRow, int expectedColumn)
        {
            var currentSquare = grid.FindSquare(startingRow,startingColumn);
            var expected = grid.FindSquare(expectedRow,expectedColumn);

            var actual = facingSouth.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,2,1)]
        [InlineData(2,2,3,2)]
        public void GetSquareLocationBehind_ShouldReturn_SquareAbove(int startingRow, int startingColumn, int expectedRow, int expectedColumn)
        {
            var currentSquare = grid.FindSquare(startingRow,startingColumn);
            var expected = grid.FindSquare(expectedRow,expectedColumn);

            var actual = facingSouth.GetSquareLocationBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}