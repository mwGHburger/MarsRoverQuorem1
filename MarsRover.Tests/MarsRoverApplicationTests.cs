using System.Collections.Generic;
using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverApplicationTests
    {
        [Fact]
        public void Run_ShouldRunTheApplication()
        {
            // var mockUserInterface = new Mock<IUserInterface>();
            // var mockRoverController = new Mock<IRoverController>();
            // var mockInputValidator = new Mock<IValidator>();
            // var marsRoverApplication = new MarsRoverApplication(
            //         mockUserInterface.Object, 
            //         mockRoverController.Object,
            //         mockInputValidator.Object
            //     );

            // mockUserInterface.SetupSequence(x => x.GetInput()).Returns("fblr");

            // marsRoverApplication.Run();

            // mockUserInterface.Verify(x => x.Print(It.IsAny<string>()));
            // mockUserInterface.Verify(x => x.GetInput());
            // mockUserInterface.Verify(x => x.ClearScreen());
            // mockInputValidator.Verify(x => x.Validate(It.IsAny<string>()));
            // mockRoverController.Verify(x => x.ExecuteInputCommands(It.IsAny<List<char>>()));
        }
    }
}