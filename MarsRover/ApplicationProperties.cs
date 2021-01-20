using System.Collections.Generic;

namespace MarsRover
{
    public static class ApplicationProperties
    {
        public static int NumberOfRows = 8;
        public static int NumberOfColumns = 8;
        public static int NumberOfObstacles = 10;
        public static List<char> ValidRoverCommands = new List<char>()
        {
            'f',
            'b',
            'r',
            'l'
        };
    }
}