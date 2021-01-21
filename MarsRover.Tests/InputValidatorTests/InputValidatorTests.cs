using System.Collections.Generic;
using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class InputValidatorTests
    {
        [Fact]
        public void Validate_ShouldAssessUserInputAcrossDifferentValidators()
        {
            var mockValidator = new Mock<IValidator>();
            var mockValidators = new List<IValidator>()
            {
                mockValidator.Object
            };
            var inputValidator = new InputValidator(mockValidators);
            var input = "test input";

            inputValidator.Validate(input);

            mockValidator.Verify(x => x.Validate(input), Times.Exactly(1));
        }
    }
}