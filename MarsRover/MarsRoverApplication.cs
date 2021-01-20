namespace MarsRover
{
    public class MarsRoverApplication
    {
        private IUserInterface _userInterface;
        private IRoverController _roverController;
        private IValidator _roverInputValidator;

        public MarsRoverApplication(IUserInterface userInterface, IRoverController roverController, IValidator roverInputValidator)
        {
            _userInterface = userInterface;
            _roverController = roverController;
            _roverInputValidator = roverInputValidator;
        }

        public void Run()
        {
            // SetupGrid
            // ISetup
            // RoverSetup.Setup(_userInterface) <--- inputValidators
            // GridSetup.Setup(_userInterface) <--- inputValidators
            // ObstacleSetup.Setup(_userInterface) <--- inputValidators
            // SetupRover


            while(true)
            {
                _userInterface.Print("Please enter any valid commands (comma-separated or not):\nf - move rover forward\nb- move rover backwards\nr - turn rover right\nl - turn rover left");
                try
                {
                    var userInput = _userInterface.GetInput();
                    _roverInputValidator.Validate(userInput);
                    var commands = userInput.ConvertToCharList();
                    _roverController.ExecuteInputCommands(commands);
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