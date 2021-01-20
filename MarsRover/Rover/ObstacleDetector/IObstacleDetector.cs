namespace MarsRover
{
    public interface IObstacleDetector
    {
        void AssessSquareInfront(ICardinalDirection currentDirection, ISquare currentSquare, IGrid grid);
        void AssessSquareBehind(ICardinalDirection currentDirection, ISquare currentSquare, IGrid grid);
    }
}