using System;
namespace MarsRover
{
    public class EmptyInputValidator : IValidator
    {
        public void Validate(string input)
        {
            if(String.IsNullOrWhiteSpace(input))
            {
                throw new EmptyInputException("You have entered nothing. Rover will do nothing");
            }
        }
    }
}