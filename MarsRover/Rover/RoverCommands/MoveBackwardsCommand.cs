namespace MarsRover
{
    public class MoveBackwardsCommand : IRoverCommand
    {
        public char KeyCommand { get; } = 'b';
        private IRover _rover;
        private IGrid _grid;
        
        public MoveBackwardsCommand(IRover rover, IGrid grid)
        {
            _rover = rover;
            _grid = grid;
        }

        public void Execute()
        {
            _rover.DetectObstacleBehind(_grid);
            _rover.MoveBackwards(_grid);
        }
    }
}