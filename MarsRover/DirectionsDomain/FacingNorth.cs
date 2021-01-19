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

        public ISquare GetSquareLocationInfront(ISquare currentSquare, IGrid grid)
        {
            var newRow = (currentSquare.Row + 1 > grid.Rows) ? 1 : currentSquare.Row + 1;
            return grid.Find(newRow, currentSquare.Column);
        }

        public ISquare GetSquareLocationBehind(ISquare currentSquare, IGrid grid)
        {
            var newRow = (currentSquare.Row - 1).Equals(0) ? grid.Rows : currentSquare.Row - 1;
            return grid.Find(newRow, currentSquare.Column);
        }
        
    }
}