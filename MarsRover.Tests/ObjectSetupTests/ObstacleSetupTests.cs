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
            // TODO: Move to test helper
            var squares = new List<ISquare>()
            {
                new Square(1,1),
                new Square(1,2),
                new Square(1,3),
                new Square(2,1),
                new Square(2,2),
                new Square(2,3),
                new Square(3,1),
                new Square(3,2),
                new Square(3,3),
            };

            mockGrid.Setup(x => x.Squares).Returns(squares);

            obstacleSetup.Setup();

            mockRandomiser.Verify(x => x.GetRandomNumber(It.IsAny<Int32>()));
        }
    }
}