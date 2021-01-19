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

        public Square GetSquareLocationInfront(Square currentSquare, Grid grid)
        {
            var newRow = (currentSquare.Row + 1 > grid.Rows) ? 1 : currentSquare.Row + 1;
            return grid.Find(newRow, currentSquare.Column);
        }
        
    }
}