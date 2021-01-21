namespace MarsRover
{
    public class RoverGPS : IRoverGPS
    {
        private IRover _rover;

        public RoverGPS(IRover rover)
        {
            _rover = rover;
        }
        public string GetLocationString()
        {
            return $"Rover is currently at {_rover.CurrentSquareLocation.Column}, {_rover.CurrentSquareLocation.Row} facing {_rover.CurrentFacingDirection.Name}";
        }
    }
}