using System;
namespace MarsRover
{
    public class RoverMovementException : Exception
    {
        public RoverMovementException(string message) : base(message)
        {}
    }
}