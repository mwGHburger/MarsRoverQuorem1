using System.Collections.Generic;

namespace MarsRover
{
    public class InputValidator : IValidator
    {
        private List<IValidator> _validators;

        public InputValidator(List<IValidator> validators)
        {
            _validators = validators;
        }

        public void Validate(string input)
        {
            foreach(IValidator validator in _validators)
            {
                validator.Validate(input);
            }
        }
    }
}