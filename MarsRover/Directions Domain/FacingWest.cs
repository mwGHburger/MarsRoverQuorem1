namespace MarsRover
{
    public class FacingWest : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.West;
        public ICardinalDirection TurnLeft()
        {
            return new FacingSouth();
        }
    }
}