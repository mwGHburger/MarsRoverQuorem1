namespace MarsRover
{
    public interface IRoverCommand
    {
        char KeyCommand { get; }
        void Execute();
    }
}