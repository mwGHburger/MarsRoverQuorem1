using Xunit;

namespace MarsRover.Tests
{
    public class FacingWestTests
    {
        ICardinalDirection facingWest = new FacingWest();
        IGrid grid = new Grid(4,4);

        [Fact]
        public void GetLeftDirection_ShouldReturn_DirectionFacingNorth()
        {
            var actual = facingWest.GetLeftDirection().Name;

            Assert.Equal(DirectionName.South, actual);
        }

        [Fact]
        public void GetRightDirection_ShouldReturn_DirectionFacingSouth()
        {
            var actual = facingWest.GetRightDirection().Name;

            Assert.Equal(DirectionName.North, actual);
        }

        [Theory]
        [InlineData(1,1,1,4)]
        [InlineData(2,2,2,1)]
        public void GetSquareLocationInfront_ShouldReturn_SquareToTheRight(int startingRow, int startingColumn, int expectedRow, int expectedColumn)
        {
            var currentSquare = grid.FindSquare(startingRow,startingColumn);
            var expected = grid.FindSquare(expectedRow,expectedColumn);

            var actual = facingWest.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,1,2)]
        [InlineData(2,2,2,3)]
        public void GetSquareLocationBehind_ShouldReturn_SquareToTheLeft(int startingRow, int startingColumn, int expectedRow, int expectedColumn)
        {
            var currentSquare = grid.FindSquare(startingRow,startingColumn);
            var expected = grid.FindSquare(expectedRow,expectedColumn);

            var actual = facingWest.GetSquareLocationBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}