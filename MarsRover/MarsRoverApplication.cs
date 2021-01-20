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
            _userInterface.Print(StandardMessages.WelcomeMessage);
            _userInterface.Print("Landing Rover onto Grid...\n");
            _roverSetup.Setup();
            _userInterface.Print("Creating obstacles...");
            _obstacleSetup.Setup();

            while(true)
            {
                _userInterface.Print(_roverGPS.GetLocationString());
                _userInterface.Print(_gridDisplay.GetGridAsString());
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
                    _userInterface.ClearScreen();
                    _userInterface.Print(ex.Message);
                }
                catch(InvalidCommandException ex)
                {
                    _userInterface.ClearScreen();
                    _userInterface.Print(ex.Message);
                }
                catch(RoverMovementException ex)
                {
                    _userInterface.ClearScreen();
                    _userInterface.Print(ex.Message);
                }
            }
        }
    }
}