using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTests
    {
        [Fact]
        public void TurnLeft_ShouldChangeTheCardinalDirectionTheRoverIsFacing()
        {
            var mockDirection = new Mock<ICardinalDirection>();
            var rover = new Rover(mockDirection.Object);

            rover.TurnLeft();

            mockDirection.Verify(x => x.TurnLeft(), Times.Exactly(1));

        }

        [Fact]
        public void TurnRight_ShouldChangeTheCardinalDirectionTheRoverIsFacing()
        {
            var mockDirection = new Mock<ICardinalDirection>();
            var rover = new Rover(mockDirection.Object);

            rover.TurnRight();

            mockDirection.Verify(x => x.TurnRight(), Times.Exactly(1));
        }

        [Fact] 
        public void MoveForward_ShouldChangeSquareLocationOfRover()
        {
            var mockFacingDirection = new Mock<ICardinalDirection>();
            var mockGrid = new Mock<IGrid>();
            var mockSquare = new Mock<ISquare>();
            var rover = new Rover(mockFacingDirection.Object);
            rover.CurrentSquareLocation = mockSquare.Object;

            rover.MoveForward(mockGrid.Object);

            mockFacingDirection.Verify(x => x.GetSquareLocationInfront(It.IsAny<ISquare>(), It.IsAny<IGrid>()));

        }
    }
}