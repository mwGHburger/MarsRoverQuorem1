using Xunit;

namespace MarsRover.Tests
{
    public class FacingSouthTests
    {
        [Fact]
        public void TurnLeft_ShouldReturn_DirectionFacingNorth()
        {
            var facingSouth = new FacingSouth();

            var actual = facingSouth.GetLeftDirection().Name;

            Assert.Equal(DirectionName.East, actual);
        }

        [Fact]
        public void TurnRight_ShouldReturn_DirectionFacingSouth()
        {
            var facingSouth = new FacingSouth();

            var actual = facingSouth.GetRightDirection().Name;

            Assert.Equal(DirectionName.West, actual);
        }

        [Fact]
        public void GetSquareLocationInfront_ShouldReturn_SquareBelow()
        {
            var facingSouth = new FacingSouth();
            var grid = new Grid(4,4);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(4,1);

            var actual = facingSouth.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSquareLocationBehind_ShouldReturn_SquareAbove()
        {
            var facingSouth = new FacingSouth();
            var grid = new Grid(4,4);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(2,1);

            var actual = facingSouth.GetSquareLocationBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}