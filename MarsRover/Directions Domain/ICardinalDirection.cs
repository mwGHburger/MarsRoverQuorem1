namespace MarsRover
{
    public interface ICardinalDirection
    {
        DirectionName Name { get; }
        ICardinalDirection TurnLeft();
        ICardinalDirection TurnRight();
        
        Square GetSquareLocationInfront(Square currentSquare, Grid grid);
    }
}