using Xunit;

namespace MarsRover.Tests
{
    public class InvalidCommandValidatorTests
    {
        [Theory]
        [InlineData("z")]
        public void Validate_ShouldThrow_InvalidCommandException_ForInvalidRoverCommands(string input)
        {
            var invalidCommandValidator = new InvalidCommandValidator();

            var exception = Assert.Throws<InvalidCommandException>(() => invalidCommandValidator.Validate(input));

            Assert.Equal("You have entered an invalid rover command. Rover will do nothing.", exception.Message);
        }
    }
}