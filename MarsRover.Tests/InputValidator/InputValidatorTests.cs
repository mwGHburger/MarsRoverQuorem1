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
            var mockFirstValidator = new Mock<IValidator>();
            var mockSecondValidator = new Mock<IValidator>();
            var mockThirdValidator = new Mock<IValidator>();
            var mockValidators = new List<IValidator>() 
            { 
                mockFirstValidator.Object,
                mockSecondValidator.Object,
                mockThirdValidator.Object
            };
            var inputValidator = new InputValidator(mockValidators);
            var input = "test input";

            inputValidator.Validate(input);

            mockFirstValidator.Verify(x => x.Validate(input), Times.Exactly(1));
            mockSecondValidator.Verify(x => x.Validate(input), Times.Exactly(1));
            mockThirdValidator.Verify(x => x.Validate(input), Times.Exactly(1));
        }
    }
}