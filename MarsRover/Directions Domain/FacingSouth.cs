namespace MarsRover
{
    public class FacingSouth : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.South;
        
        public ICardinalDirection TurnLeft()
        {
            return new FacingEast();
        }

        public ICardinalDirection TurnRight()
        {
            return new FacingWest();
        }

        public Square GetSquareLocationInfront(Square currentSquare, Grid grid)
        {
            var newRow = (currentSquare.Row - 1).Equals(0) ? grid.Rows : currentSquare.Row - 1;
            return grid.Find(newRow, currentSquare.Column);
        }
    }
}