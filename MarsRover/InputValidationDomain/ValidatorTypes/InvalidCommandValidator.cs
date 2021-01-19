using System.Text.RegularExpressions;

namespace MarsRover
{
    public class InvalidCommandValidator : IValidator
    {
        public void Validate(string input)
        {
            var pattern = @"^[0-9]+$";
            var regex = new Regex(pattern);
            if(!regex.IsMatch(input))
            {
                throw new InvalidCommandException("You have entered an invalid rover command. Rover will do nothing.");
            }
        }
    }
}