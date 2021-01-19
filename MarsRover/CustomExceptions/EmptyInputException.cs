using System;
namespace MarsRover
{
    public class EmptyInputException : Exception
    {
        public EmptyInputException(string message) : base(message)
        {}
    }
}