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
            var squares = TestHelper.SetupSquares();

            mockGrid.Setup(x => x.Squares).Returns(squares);

            obstacleSetup.Setup();

            mockRandomiser.Verify(x => x.GetRandomNumber(It.IsAny<Int32>()));
        }
    }
}