namespace MarsRover
{
    public class RoverSetup : ISetup
    {
        private IRover _rover;
        private IGrid _grid;

        public RoverSetup(IRover rover, IGrid grid)
        {
            _rover = rover;
            _grid = grid;
        }

        public void Setup()
        {
            var startingSquareLocation = _grid.FindSquare(1,1);
            _rover.CurrentSquareLocation = startingSquareLocation;
        }
    }
}