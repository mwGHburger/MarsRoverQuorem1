namespace MarsRover
{
    public class MarsRoverApplication
    {
        private IUserInterface _userInterface;
        private IRoverController _roverController;
        private IRoverGPS _roverGPS;
        private IValidator _roverInputValidator;
        private ISetup _roverSetup;
        private ISetup _obstacleSetup;

        public MarsRoverApplication(IUserInterface userInterface, IRoverController roverController, IRoverGPS roverGPS, IValidator roverInputValidator, ISetup roverSetup, ISetup obstacleSetup)
        {
            _userInterface = userInterface;
            _roverController = roverController;
            _roverGPS = roverGPS;
            _roverInputValidator = roverInputValidator;
            _roverSetup = roverSetup;
            _obstacleSetup = obstacleSetup;
        }

        public void Run()
        {
            _roverSetup.Setup(_userInterface);
            _obstacleSetup.Setup(_userInterface);


            while(true)
            {
                _userInterface.Print(_roverGPS.GetLocationString());
                _userInterface.Print("Please enter any valid commands (comma-separated or not):\nf - move rover forward\nb- move rover backwards\nr - turn rover right\nl - turn rover left");
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