using Xunit;

namespace MarsRover.Tests
{
    public class FacingWestTests
    {
        [Fact]
        public void TurnLeft_ShouldReturn_DirectionFacingNorth()
        {
            var facingWest = new FacingWest();

            var actual = facingWest.TurnLeft().Name;

            Assert.Equal(DirectionName.South, actual);
        }

        [Fact]
        public void TurnRight_ShouldReturn_DirectionFacingSouth()
        {
            var facingWest = new FacingWest();

            var actual = facingWest.TurnRight().Name;

            Assert.Equal(DirectionName.North, actual);
        }

        [Fact]
        public void GetSquareLocationInfront_ShouldReturn_SquareToTheRight()
        {
            var facingWest = new FacingWest();
            var grid = new Grid(4,4);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,4);

            var actual = facingWest.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}