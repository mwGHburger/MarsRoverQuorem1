using Xunit;

namespace MarsRover.Tests
{
    public class FacingEastTests
    {
        [Fact]
        public void TurnLeft_ShouldReturn_DirectionFacingNorth()
        {
            var facingEast = new FacingEast();

            var actual = facingEast.TurnLeft().Name;

            Assert.Equal(DirectionName.North, actual);
        }

        [Fact]
        public void TurnRight_ShouldReturn_DirectionFacingSouth()
        {
            var facingEast = new FacingEast();

            var actual = facingEast.TurnRight().Name;

            Assert.Equal(DirectionName.South, actual);
        }

        [Fact]
        public void GetSquareLocationInfront_ShouldReturn_SquareToTheRight()
        {
            var facingEast = new FacingEast();
            var grid = new Grid(4,4);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,2);

            var actual = facingEast.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

    }
}