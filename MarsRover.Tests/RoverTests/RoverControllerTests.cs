using System.Collections.Generic;
using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverControllerTests
    {
        [Fact]
        public void ExecuteInputCommands_ShouldExecuteTheRelevantRoverCommands()
        {
            var mockRoverCommand = new Mock<IRoverCommand>();
            var mockCommandsList = new List<IRoverCommand>()
            {
                mockRoverCommand.Object
            };
            var userInputCommands = new List<char>()
            {
                'r'
            };
            var roverController = new RoverController(mockCommandsList);

            mockRoverCommand.Setup(x => x.KeyCommand).Returns('r');

            roverController.ExecuteInputCommands(userInputCommands);

            mockRoverCommand.Verify(x => x.Execute(), Times.Exactly(1));
        }
    }
}