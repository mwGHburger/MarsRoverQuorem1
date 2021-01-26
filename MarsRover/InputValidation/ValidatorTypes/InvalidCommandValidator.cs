using System.Text.RegularExpressions;

namespace MarsRover
{
    public class InvalidCommandValidator : IValidator
    {
        public void Validate(string input)
        {
            var formattedInput = input.Replace(",","").ToLower();
            var inputCommands = formattedInput.ToCharArray();
            foreach(var inputCommand in inputCommands)
            {
                if(!ApplicationProperties.ValidRoverCommands.Contains(inputCommand))
                {
                    throw new InvalidCommandException(StandardMessages.InvalidCommandExceptionMessage);
                }
            }
        }
    }
}