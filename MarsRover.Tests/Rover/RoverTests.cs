using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTests
    {
        [Fact]
        public void TurnLeft_ShouldChangeTheCardinalDirectionTheRoverIsFacing()
        {
            var mockObstacleDetector = new Mock<IObstacleDetector>();
            var mockDirection = new Mock<ICardinalDirection>();
            var rover = new Rover(mockDirection.Object, mockObstacleDetector.Object);

            rover.TurnLeft();

            mockDirection.Verify(x => x.GetLeftDirection(), Times.Exactly(1));
        }

        [Fact]
        public void TurnRight_ShouldChangeTheCardinalDirectionTheRoverIsFacing()
        {
            var mockObstacleDetector = new Mock<IObstacleDetector>();
            var mockDirection = new Mock<ICardinalDirection>();
            var rover = new Rover(mockDirection.Object, mockObstacleDetector.Object);

            rover.TurnRight();

            mockDirection.Verify(x => x.GetRightDirection(), Times.Exactly(1));
        }

        [Fact] 
        public void MoveForward_ShouldChangeSquareLocationOfRover()
        {
            var mockObstacleDetector = new Mock<IObstacleDetector>();
            var mockFacingDirection = new Mock<ICardinalDirection>();
            var mockGrid = new Mock<IGrid>();
            var mockSquare = new Mock<ISquare>();
            var rover = new Rover(mockFacingDirection.Object, mockObstacleDetector.Object);
            rover.CurrentSquareLocation = mockSquare.Object;

            rover.MoveForward(mockGrid.Object);

            mockFacingDirection.Verify(x => x.GetSquareLocationInfront(It.IsAny<ISquare>(), It.IsAny<IGrid>()));
        }

        [Fact] 
        public void MoveBackwards_ShouldChangeSquareLocationOfRover()
        {
            var mockObstacleDetector = new Mock<IObstacleDetector>();
            var mockFacingDirection = new Mock<ICardinalDirection>();
            var mockGrid = new Mock<IGrid>();
            var mockSquare = new Mock<ISquare>();
            var rover = new Rover(mockFacingDirection.Object, mockObstacleDetector.Object);
            rover.CurrentSquareLocation = mockSquare.Object;

            rover.MoveBackwards(mockGrid.Object);

            mockFacingDirection.Verify(x => x.GetSquareLocationBehind(It.IsAny<ISquare>(), It.IsAny<IGrid>()));
        }

        [Fact] 
        public void DetectObstacleInfront_ShouldCallAssessSquareInfrontMethodOfObstacleDetector()
        {
            var mockFacingDirection = new Mock<ICardinalDirection>();
            var mockObstacleDetector = new Mock<IObstacleDetector>();
            var mockGrid = new Mock<IGrid>();
            var rover = new Rover(mockFacingDirection.Object, mockObstacleDetector.Object);

            rover.DetectObstacleInfront(mockGrid.Object);

            mockObstacleDetector.Verify(x => x.AssessSquareInfront(It.IsAny<ICardinalDirection>(), It.IsAny<ISquare>(),It.IsAny<IGrid>()));
        }

        [Fact] 
        public void DetectObstacleBehind_ShouldCallAssessSquareBehindMethodOfObstacleDetector()
        {
            var mockFacingDirection = new Mock<ICardinalDirection>();
            var mockObstacleDetector = new Mock<IObstacleDetector>();
            var mockGrid = new Mock<IGrid>();
            var rover = new Rover(mockFacingDirection.Object, mockObstacleDetector.Object);

            rover.DetectObstacleBehind(mockGrid.Object);

            mockObstacleDetector.Verify(x => x.AssessSquareBehind(It.IsAny<ICardinalDirection>(), It.IsAny<ISquare>(),It.IsAny<IGrid>()));
        }
    }
}