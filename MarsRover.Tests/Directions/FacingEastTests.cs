using Xunit;

namespace MarsRover.Tests
{
    public class FacingEastTests
    {
        ICardinalDirection facingEast = new FacingEast();

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

        [Fact]
        public void GetSquareLocationInfront_ShouldReturn_SquareToTheRight()
        {
            var grid = TestHelper.SetupGrid();
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,2);

            var actual = facingEast.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSquareLocationBehind_ShouldReturn_SquareToTheLeft()
        {
            var grid = TestHelper.SetupGrid();
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,4);

            var actual = facingEast.GetSquareLocationBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

    }
}