namespace MarsRover
{
    public interface IGrid
    {
        int Rows { get; }
        int Columns { get; }
        ISquare Find(int row, int column);
    }
}