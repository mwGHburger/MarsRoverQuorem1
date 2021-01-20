namespace MarsRover
{
    public class Square : ISquare
    {
        public int Row { get; }
        public int Column { get; }

        public SquareState SquareState { get; }

        public Square(int row, int column)
        {
            Row = row;
            Column = column;
            SquareState = SquareState.Empty;
        }
    }
}