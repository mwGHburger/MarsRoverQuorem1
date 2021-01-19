namespace MarsRover
{
    public class RoverMoveBackwardsCommand : IRoverCommand
    {
        public char KeyCommand { get; } = 'b';
        private IRover _rover;
        private IGrid _grid;
        
        public RoverMoveBackwardsCommand(IRover rover, IGrid grid)
        {
            _rover = rover;
            _grid = grid;
        }

        public void Execute()
        {
            _rover.MoveBackwards(_grid);
        }
    }
}