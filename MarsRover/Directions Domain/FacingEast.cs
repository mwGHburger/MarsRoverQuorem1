namespace MarsRover
{
    public class FacingEast : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.East;

        public ICardinalDirection TurnLeft()
        {
            return new FacingNorth();
        }

        public ICardinalDirection TurnRight()
        {
            return new FacingSouth();
        }

        public Square GetSquareLocationInfront(Square currentSquare, Grid grid)
        {
            var newColumn = (currentSquare.Column + 1 > grid.Columns) ? 1 : currentSquare.Column + 1;
            return grid.Find(currentSquare.Row, newColumn);
        }
    }
}