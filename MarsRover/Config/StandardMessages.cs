namespace MarsRover
{
    public static class StandardMessages
    {
        public static string WelcomeMessage = "Welcome to the Mars Rover Application!\n";
        public static string ValidCommands = "\nPlease enter any valid commands (comma-separated or not):\nf - To move rover forward\nb - To move rover backwards\nr - To turn rover right\nl - To turn rover left";
        public static string RoverSetup = "Landing Rover onto Grid...\n";
        public static string ObstacleSetup = "Creating obstacles on the Grid...\n";
        public static string DetectedObstacleInfront = "Obstacle detected infront of Rover. Rover cannot move forward.";
        public static string DetectedObstacleBehind = "Obstacle detected behind the Rover. Rover cannot move backwards.";
        public static string EmptyInputExceptionMessage = "You have entered nothing. Rover will do nothing";
        public static string InvalidCommandExceptionMessage = "You have entered an invalid rover command. Rover will do nothing.";
    }
}