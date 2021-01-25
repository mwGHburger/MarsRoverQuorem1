using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTurnLeftCommandTests
    {
        [Fact]
        public void Execute_ShouldCallTheTurnLeftMethodOnRover()
        {
            var mockRover = new Mock<IRover>();
            var roverTurnLeftCommand = new RoverTurnLeftCommand(mockRover.Object);

            roverTurnLeftCommand.Execute();

            mockRover.Verify(x => x.TurnLeft(), Times.Exactly(1));
        }
    }
}