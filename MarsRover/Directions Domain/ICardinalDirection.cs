namespace MarsRover
{
    public interface ICardinalDirection
    {
        DirectionName Name { get; }
        ICardinalDirection TurnLeft();
    }
}