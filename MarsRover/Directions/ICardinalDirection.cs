namespace MarsRover
{
    public interface ICardinalDirection
    {
        DirectionName Name { get; }
        ICardinalDirection GetLeftDirection();
        ICardinalDirection GetRightDirection();
        
        ISquare GetSquareLocationInfront(ISquare currentSquare, IGrid grid);
        ISquare GetSquareLocationBehind(ISquare currentSquare, IGrid grid);
    }
}