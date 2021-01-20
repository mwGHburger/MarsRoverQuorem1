using System.Collections.Generic;

namespace MarsRover
{
    public static class ClassInstantiatorFactory
    {
        private static IRover _rover = CreateRover();
        private static IGrid _grid = CreateGrid();
        public static MarsRoverApplication CreateMarsRoverApplication()
        {
            return new MarsRoverApplication(CreateCommandLineInterface(), CreateRoverController(), CreateRoverInputValidator());
        }

        private static IUserInterface CreateCommandLineInterface()
        {
            return new CommandLineInterface();
        }

        private static IRoverController CreateRoverController()
        {
            return new RoverController(CreateRoverCommands());
        }

        private static IValidator CreateRoverInputValidator()
        {
            return new InputValidator(
                new List<IValidator>()
                {
                    new EmptyInputValidator(),
                    new InvalidCommandValidator()
                }
            );
        }

        private static List<IRoverCommand> CreateRoverCommands()
        {
            return new List<IRoverCommand>()
            {
                new RoverTurnLeftCommand(_rover),
                new RoverTurnRightCommand(_rover),
                new RoverMoveForwardCommand(_rover, _grid),
                new RoverMoveBackwardsCommand(_rover, _grid)
            };
        }

        private static IRover CreateRover()
        {
            return new Rover(new FacingNorth(), CreateObstacleDetector());
        }

        private static IGrid CreateGrid()
        {
            return new Grid(8,8);
        }

        private static IObstacleDetector CreateObstacleDetector()
        {
            return new ObstacleDetector();
        }
    }
}