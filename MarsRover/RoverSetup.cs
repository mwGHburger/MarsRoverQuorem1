namespace MarsRover
{
    public class RoverSetup
    {
        private IRover _rover;
        private IGrid _grid;

        public RoverSetup(IRover rover, IGrid grid)
        {
            _rover = rover;
            _grid = grid;
        }

        public void Setup(IUserInterface userInterface)
        {
            userInterface.Print("Landing Rover onto Grid...\n");
            var startingSquareLocation = _grid.Find(1,1);
            _rover.CurrentSquareLocation = startingSquareLocation;
        }
    }
}