namespace MarsRover
{
    public class RoverGPSDisplay : IDisplay
    {
        private IRover _rover;

        public RoverGPSDisplay(IRover rover)
        {
            _rover = rover;
        }
        public string GetDisplayString()
        {
            return $"Rover is currently at {_rover.CurrentSquareLocation.Column}, {_rover.CurrentSquareLocation.Row} facing {_rover.CurrentFacingDirection.Name}";
        }
    }
}