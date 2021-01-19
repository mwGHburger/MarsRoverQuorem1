namespace MarsRover
{
    public class RoverTurnLeftCommand : IRoverCommand
    {
        public char KeyCommand { get; } = 'l';
        private IRover _rover;

        public RoverTurnLeftCommand(IRover rover)
        {
            _rover = rover;
        }

        public void Execute()
        {
            _rover.TurnLeft();
        }
    }
}