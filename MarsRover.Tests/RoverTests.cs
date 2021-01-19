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
    }
}