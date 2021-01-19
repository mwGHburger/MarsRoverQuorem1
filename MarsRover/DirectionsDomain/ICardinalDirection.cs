namespace MarsRover
{
    public interface ICardinalDirection
    {
        DirectionName Name { get; }
        ICardinalDirection TurnLeft();
        ICardinalDirection TurnRight();
        
        ISquare GetSquareLocationInfront(ISquare currentSquare, IGrid grid);
    }
}