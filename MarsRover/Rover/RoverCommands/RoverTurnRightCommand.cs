namespace MarsRover
{
    public class RoverTurnRightCommand : IRoverCommand
    {
        public char KeyCommand { get; } = 'r';
        private IRover _rover;

        public RoverTurnRightCommand(IRover rover)
        {
            _rover = rover;
        }

        public void Execute()
        {
            _rover.TurnRight();
        }
    }
}