using Xunit;

namespace MarsRover.Tests
{
    public class FacingNorthTests
    {
        [Fact]
        public void TurnLeft_ShouldReturn_DirectionFacingNorth()
        {
            var facingNorth = new FacingNorth();

            var actual = facingNorth.TurnLeft().Name;

            Assert.Equal(DirectionName.West, actual);
        }

        [Fact]
        public void TurnRight_ShouldReturn_DirectionFacingSouth()
        {
            var facingNorth = new FacingNorth();

            var actual = facingNorth.TurnRight().Name;

            Assert.Equal(DirectionName.East, actual);
        }

        [Fact]
        public void GetSquareLocationInfront_ShouldReturn_SquareToTheRight()
        {
            var facingNorth = new FacingNorth();
            var grid = new Grid(4,4);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(2,1);

            var actual = facingNorth.GetSquareLocationInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}