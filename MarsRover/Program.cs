using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var marsRoverApplication = ClassInstantiatorFactory.CreateMarsRoverApplication();
            marsRoverApplication.Run();
        }
    }
}
