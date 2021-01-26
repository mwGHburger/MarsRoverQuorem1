using Xunit;

namespace MarsRover.Tests
{
    public class FacingEastTests
    {
        ICardinalDirection facingEast = new FacingEast();
        IGrid grid = new Grid(4,4);

        [Fact]
        public void GetLeftDirection_ShouldReturn_DirectionFacingNorth()
        {
            var actual = facingEast.GetLeftDirection().Name;

            Assert.Equal(DirectionName.North, actual);
        }

        [Fact]
        public void GetRightDirection_ShouldReturn_DirectionFacingSouth()
        {
            var actual = facingEast.GetRightDirection().Name;

            Assert.Equal(DirectionName.South, actual);
        }

        [Theory]
        [InlineData(1,1,1,2)]
        [InlineData(2,2,2,3)]
        public void GetSquareLocationInfront_ShouldReturn_SquareToTheRight(int startingRow, int startingColumn, int expectedRow, int expectedColumn)
        {
            var currentSquare = grid.Find(startingRow,startingColumn);
            var expected = grid.Find(expectedRow,expectedColumn);

            var actual = facingEast.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,1,4)]
        [InlineData(2,2,2,1)]
        public void GetSquareLocationBehind_ShouldReturn_SquareToTheLeft(int startingRow, int startingColumn, int expectedRow, int expectedColumn)
        {
            var currentSquare = grid.Find(startingRow,startingColumn);
            var expected = grid.Find(expectedRow,expectedColumn);

            var actual = facingEast.GetSquareLocationBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

    }
}