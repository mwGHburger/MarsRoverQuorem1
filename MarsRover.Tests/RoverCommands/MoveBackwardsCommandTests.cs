using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class MoveBackwardsCommandTests
    {
        [Fact]
        public void Execute_ShouldCallTheTurnLeftMethodOnRover()
        {
            var mockRover = new Mock<IRover>();
            var mockGrid = new Mock<IGrid>();
            var roverTurnRightCommand = new MoveBackwardsCommand(mockRover.Object, mockGrid.Object);

            roverTurnRightCommand.Execute();

            mockRover.Verify(x => x.DetectObstacleBehind(mockGrid.Object), Times.Exactly(1));
            mockRover.Verify(x => x.MoveBackwards(mockGrid.Object), Times.Exactly(1));
        }
    }
}