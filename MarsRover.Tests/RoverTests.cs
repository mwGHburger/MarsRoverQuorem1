using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTests
    {
        [Fact]
        public void TurnLeft_ShouldChangeTheCardinalDirectionTheRoverIsFacing()
        {
            var rover = new Rover(new FacingNorth());

            var expected = DirectionName.West;

            rover.TurnLeft();

            Assert.Equal(expected, rover.CurrentFacingDirection.Name);
        }

        [Fact]
        public void TurnRight_ShouldChangeTheCardinalDirectionTheRoverIsFacing()
        {
            var rover = new Rover(new FacingNorth());

            var expected = DirectionName.East;

            rover.TurnRight();

            Assert.Equal(expected, rover.CurrentFacingDirection.Name);
        }

        // Integration Test
        [Fact] 
        public void MoveForward_ShouldChangeSquareLocationOfRover()
        {
            var mockFacingDirection = new Mock<ICardinalDirection>();
            var rover = new Rover(new FacingNorth());
            var grid = new Grid(4,4);
            var startingSquare = grid.Find(1,1);
            rover.CurrentSquareLocation = startingSquare;

            var expected = grid.Find(2,1);

            rover.MoveForward(grid);

            Assert.Equal(expected, rover.CurrentSquareLocation);
        }
    }
}