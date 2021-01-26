namespace MarsRover
{
    public class TurnRightCommand : IRoverCommand
    {
        public char KeyCommand { get; } = 'r';
        private IRover _rover;

        public TurnRightCommand(IRover rover)
        {
            _rover = rover;
        }

        public void Execute()
        {
            _rover.TurnRight();
        }
    }
}