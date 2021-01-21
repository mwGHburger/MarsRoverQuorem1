using System;
namespace MarsRover
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException(string message) : base(message)
        {}
    }
}