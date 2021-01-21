namespace MarsRover
{
    public class FacingEast : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.East;

        public ICardinalDirection GetLeftDirection()
        {
            return new FacingNorth();
        }

        public ICardinalDirection GetRightDirection()
        {
            return new FacingSouth();
        }

        public ISquare GetSquareLocationInfront(ISquare currentSquare, IGrid grid)
        {
            var newColumn = (currentSquare.Column + 1 > grid.Columns) ? 1 : currentSquare.Column + 1;
            return grid.Find(currentSquare.Row, newColumn);
        }

        public ISquare GetSquareLocationBehind(ISquare currentSquare, IGrid grid)
        {
            var newColumn = (currentSquare.Column - 1).Equals(0) ? grid.Columns : currentSquare.Column - 1;
            return grid.Find(currentSquare.Row, newColumn);
        }
    }
}