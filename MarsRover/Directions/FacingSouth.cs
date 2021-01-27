namespace MarsRover
{
    public class FacingSouth : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.South;
        
        public ICardinalDirection GetLeftDirection()
        {
            return new FacingEast();
        }

        public ICardinalDirection GetRightDirection()
        {
            return new FacingWest();
        }

        public ISquare GetSquareLocationInfront(ISquare currentSquare, IGrid grid)
        {
            var newRow = (currentSquare.Row - 1).Equals(0) ? grid.Rows : currentSquare.Row - 1;
            return grid.FindSquare(newRow, currentSquare.Column);
        }

        public ISquare GetSquareLocationBehind(ISquare currentSquare, IGrid grid)
        {
            var newRow = (currentSquare.Row + 1 > grid.Rows) ? 1 : currentSquare.Row + 1;
            return grid.FindSquare(newRow, currentSquare.Column);
        }
    }
}