using Xunit;

namespace MarsRover.Tests
{
    public class FacingNorthTests
    {
        ICardinalDirection facingNorth = new FacingNorth();

        [Fact]
        public void GetLeftDirection_ShouldReturn_DirectionFacingNorth()
        {
            var actual = facingNorth.GetLeftDirection().Name;

            Assert.Equal(DirectionName.West, actual);
        }

        [Fact]
        public void GetRightDirection_ShouldReturn_DirectionFacingSouth()
        {
            var actual = facingNorth.GetRightDirection().Name;

            Assert.Equal(DirectionName.East, actual);
        }

        [Fact]
        public void GetSquareLocationInfront_ShouldReturn_SquareAbove()
        {
            var grid = TestHelper.SetupGrid();
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(2,1);

            var actual = facingNorth.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSquareLocationBehind_ShouldReturn_SquareBelow()
        {
            var grid = TestHelper.SetupGrid();
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(4,1);

            var actual = facingNorth.GetSquareLocationBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}