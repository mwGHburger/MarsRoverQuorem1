namespace MarsRover
{
    public class RoverMoveForwardCommand : IRoverCommand
    {
        public char KeyCommand { get; } = 'f';
        private IRover _rover;
        private IGrid _grid;

        public RoverMoveForwardCommand(IRover rover, IGrid grid)
        {
            _rover = rover;
            _grid = grid;
        }

        public void Execute()
        {
            _rover.DetectObstacleInfront(_grid);
            _rover.MoveForward(_grid);
        }
    }
}