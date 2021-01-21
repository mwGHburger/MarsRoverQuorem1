using System;

namespace MarsRover
{
    public class CommandLineInterface : IUserInterface
    {
        public void Print(string input)
        {
            Console.WriteLine(input);
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}