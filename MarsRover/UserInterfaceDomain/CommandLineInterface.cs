using System;

namespace MarsRover
{
    public class CommandLineInterface : IUserInterface
    {
        public void Print(string input)
        {
            Console.WriteLine();
        }

        public string GetInput(string prompt)
        {
            Print(prompt);
            return Console.ReadLine();
        }
    }
}