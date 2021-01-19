using Xunit;

namespace MarsRover.Tests
{
    public class EmptyInputValidatorTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void Validate_ShouldThrowEmptyInputExceptionForEmptyInput(string input)
        {
            var emptyInputValidator = new EmptyInputValidator();

            var exception = Assert.Throws<EmptyInputException>(() => emptyInputValidator.Validate(input));

            Assert.Equal("You have entered nothing. Rover will do nothing", exception.Message);
        }
    }
}