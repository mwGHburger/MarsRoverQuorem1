using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class TurnRightCommandTests
    {
        [Fact]
        public void Execute_ShouldCallTheTurnLeftMethodOnRover()
        {
            var mockRover = new Mock<IRover>();
            var roverTurnRightCommand = new TurnRightCommand(mockRover.Object);

            roverTurnRightCommand.Execute();

            mockRover.Verify(x => x.TurnRight(), Times.Exactly(1));
        }
    }
}