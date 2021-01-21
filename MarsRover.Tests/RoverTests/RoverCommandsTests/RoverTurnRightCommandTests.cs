using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTurnRightCommandTests
    {
        [Fact]
        public void Execute_ShouldCallTheTurnLeftMethodOnRover()
        {
            var mockRover = new Mock<IRover>();
            var roverTurnRightCommand = new RoverTurnRightCommand(mockRover.Object);

            roverTurnRightCommand.Execute();

            mockRover.Verify(x => x.TurnRight(), Times.Exactly(1));
        }
    }
}