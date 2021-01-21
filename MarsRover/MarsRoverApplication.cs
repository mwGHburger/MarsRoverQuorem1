using System;
namespace MarsRover
{
    public class MarsRoverApplication
    {
        private IUserInterface _userInterface;
        private IRoverController _roverController;
        private IRoverGPS _roverGPS;
        private IGridDisplay _gridDisplay;
        private IValidator _roverInputValidator;
        private ISetup _roverSetup;
        private ISetup _obstacleSetup;

        public MarsRoverApplication(IUserInterface userInterface, IRoverController roverController, IRoverGPS roverGPS, IGridDisplay gridDisplay, IValidator roverInputValidator, ISetup roverSetup, ISetup obstacleSetup)
        {
            _userInterface = userInterface;
            _roverController = roverController;
            _roverGPS = roverGPS;
            _gridDisplay = gridDisplay;
            _roverInputValidator = roverInputValidator;
            _roverSetup = roverSetup;
            _obstacleSetup = obstacleSetup;
        }

        public void Run()
        {
            Setup();
            while(true)
            {
                _userInterface.Print(_roverGPS.GetLocationString());
                _userInterface.Print(_gridDisplay.GetGridString());
                _userInterface.Print(StandardMessages.ValidCommands);
                try
                {
                    var userInput = _userInterface.GetInput();
                    _roverInputValidator.Validate(userInput);
                    var commands = userInput.ConvertToCharList();
                    _roverController.ExecuteInputCommands(commands);
                    _userInterface.ClearScreen();
                }
                catch(EmptyInputException ex)
                {
                    HandleException(ex);
                }
                catch(InvalidCommandException ex)
                {
                    HandleException(ex);
                }
                catch(RoverMovementException ex)
                {
                    HandleException(ex);
                }
            }
        }

        private void Setup()
        {
            _userInterface.Print(StandardMessages.WelcomeMessage);
            _userInterface.Print(StandardMessages.RoverSetup);
            _roverSetup.Setup();
            _userInterface.Print(StandardMessages.ObstacleSetup);
            _obstacleSetup.Setup();
        }

        private void HandleException(Exception exception)
        {
            _userInterface.ClearScreen();
            _userInterface.Print(exception.Message);
        }
    }
}