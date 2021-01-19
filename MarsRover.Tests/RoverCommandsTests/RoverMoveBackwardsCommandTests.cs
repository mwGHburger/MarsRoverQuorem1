using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverMoveBackwardsCommandTests
    {
        [Fact]
        public void Execute_ShouldCallTheTurnLeftMethodOnRover()
        {
            var mockRover = new Mock<IRover>();
            var mockGrid = new Mock<IGrid>();
            var roverTurnRightCommand = new RoverMoveBackwardsCommand(mockRover.Object, mockGrid.Object);

            roverTurnRightCommand.Execute();

            mockRover.Verify(x => x.MoveBackwards(mockGrid.Object), Times.Exactly(1));
        }
    }
}