using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverMoveForwardCommandTests
    {
        [Fact]
        public void Execute_ShouldCallTheTurnLeftMethodOnRover()
        {
            var mockRover = new Mock<IRover>();
            var mockGrid = new Mock<IGrid>();
            var roverTurnRightCommand = new RoverMoveForwardCommand(mockRover.Object, mockGrid.Object);

            roverTurnRightCommand.Execute();

            mockRover.Verify(x => x.MoveForward(mockGrid.Object), Times.Exactly(1));
        }
    }
}