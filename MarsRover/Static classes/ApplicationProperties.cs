using System.Collections.Generic;

namespace MarsRover
{
    public static class ApplicationProperties
    {
        public static int NumberOfRows = 10;
        public static int NumberOfColumns = 10;
        public static int NumberOfObstacles = 8;
        public static List<char> ValidRoverCommands = new List<char>()
        {
            'f',
            'b',
            'r',
            'l'
        };
    }
}