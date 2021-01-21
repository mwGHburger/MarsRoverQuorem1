using System;

namespace MarsRover
{
    public class Randomiser : IRandomiser
    {
        public int GetRandomNumber(int maximumNumber)
        {
            var random = new Random();
            return random.Next(1,maximumNumber);
        }
    }
}