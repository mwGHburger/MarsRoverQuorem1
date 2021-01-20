using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class ObstacleDetectorTests
    {
        [Fact]
        public void AssessSquareInfront_ShouldThrowRoverMovementException()
        {
            var mockGrid = new Mock<IGrid>();
            var mockCurrentSquare = new Mock<ISquare>();
            var mockNextSquare = new Mock<ISquare>();
            var mockCurrentDirection = new Mock<ICardinalDirection>();
            var obstacleDetector = new ObstacleDetector();

            mockCurrentDirection.Setup(x => x.GetSquareLocationInfront(mockCurrentSquare.Object, mockGrid.Object)).Returns(mockNextSquare.Object);
            mockNextSquare.Setup(x => x.SquareState).Returns(SquareState.Not_Empty);

            var exception = Assert.Throws<RoverMovementException>(() => obstacleDetector.AssessSquareInfront(mockCurrentDirection.Object, mockCurrentSquare.Object, mockGrid.Object));

            Assert.Equal("Obstacle detected infront of Rover. Rover cannot move forward.", exception.Message);
        }

        [Fact]
        public void AssessSquareBehind_ShouldThrowRoverMovementException()
        {
            var mockGrid = new Mock<IGrid>();
            var mockCurrentSquare = new Mock<ISquare>();
            var mockNextSquare = new Mock<ISquare>();
            var mockCurrentDirection = new Mock<ICardinalDirection>();
            var obstacleDetector = new ObstacleDetector();

            mockCurrentDirection.Setup(x => x.GetSquareLocationBehind(mockCurrentSquare.Object, mockGrid.Object)).Returns(mockNextSquare.Object);
            mockNextSquare.Setup(x => x.SquareState).Returns(SquareState.Not_Empty);

            var exception = Assert.Throws<RoverMovementException>(() => obstacleDetector.AssessSquareBehind(mockCurrentDirection.Object, mockCurrentSquare.Object, mockGrid.Object));

            Assert.Equal("Obstacle detected behind the Rover. Rover cannot move backwards.", exception.Message);
        }
    }
}