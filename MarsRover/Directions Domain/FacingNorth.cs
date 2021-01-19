namespace MarsRover
{
    public class FacingNorth : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.North;
        
        public ICardinalDirection TurnLeft()
        {
            return new FacingWest();
        }

        public ICardinalDirection TurnRight()
        {
            return new FacingEast();
        }
    }
}