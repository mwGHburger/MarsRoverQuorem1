using Xunit;

namespace MarsRover.Tests
{
    public class FacingWestTests
    {
        [Fact]
        public void TurnLeft_ShouldReturn_DirectionFacingNorth()
        {
            var facingWest = new FacingWest();

            var actual = facingWest.GetLeftDirection().Name;

            Assert.Equal(DirectionName.South, actual);
        }

        [Fact]
        public void TurnRight_ShouldReturn_DirectionFacingSouth()
        {
            var facingWest = new FacingWest();

            var actual = facingWest.GetRightDirection().Name;

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

        [Fact]
        public void GetSquareLocationBehind_ShouldReturn_SquareToTheLeft()
        {
            var facingWest = new FacingWest();
            var grid = new Grid(4,4);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,2);

            var actual = facingWest.GetSquareLocationBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}