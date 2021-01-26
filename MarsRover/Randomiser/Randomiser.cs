using System;

namespace MarsRover
{
    public class Randomiser : IRandomiser
    {
        public int GetRandomNumber(int maximumNumber)
        {
            var minimumNumber = 1;
            var random = new Random();
            return random.Next(minimumNumber, maximumNumber);
        }
    }
}