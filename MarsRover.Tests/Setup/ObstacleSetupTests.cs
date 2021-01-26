using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class ObstacleSetupTests
    {
        [Fact]
        public void Setup_ShouldPlaceObstaclesOntoGridBasedOnUserInput()
        {
            var mockGrid = new Mock<IGrid>();
            var mockRandomiser = new Mock<IRandomiser>();
            var obstacleSetup = new ObstacleSetup(mockGrid.Object, mockRandomiser.Object);
            var mockSquare = new Mock<ISquare>();

            mockSquare.Setup(x => x.SquareState).Returns(SquareState.Empty);

            var mockSquares = new List<ISquare>()
            {
                mockSquare.Object
            };

            mockGrid.Setup(x => x.Squares).Returns(mockSquares);

            obstacleSetup.Setup();

            mockRandomiser.Verify(x => x.GetRandomNumber(It.IsAny<Int32>()));
            mockSquare.VerifySet(x => x.SquareState = SquareState.Not_Empty);
        }
    }
}