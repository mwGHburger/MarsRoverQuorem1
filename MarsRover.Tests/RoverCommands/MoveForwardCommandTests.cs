using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class MoveForwardCommandTests
    {
        [Fact]
        public void Execute_ShouldCallTheTurnLeftMethodOnRover()
        {
            var mockRover = new Mock<IRover>();
            var mockGrid = new Mock<IGrid>();
            var roverTurnRightCommand = new MoveForwardCommand(mockRover.Object, mockGrid.Object);

            roverTurnRightCommand.Execute();

            mockRover.Verify(x => x.DetectObstacleInfront(mockGrid.Object), Times.Exactly(1));
            mockRover.Verify(x => x.MoveForward(mockGrid.Object), Times.Exactly(1));
        }
    }
}