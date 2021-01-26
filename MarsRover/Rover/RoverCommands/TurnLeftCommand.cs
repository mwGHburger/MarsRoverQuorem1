namespace MarsRover
{
    public class TurnLeftCommand : IRoverCommand
    {
        public char KeyCommand { get; } = 'l';
        private IRover _rover;

        public TurnLeftCommand(IRover rover)
        {
            _rover = rover;
        }

        public void Execute()
        {
            _rover.TurnLeft();
        }
    }
}