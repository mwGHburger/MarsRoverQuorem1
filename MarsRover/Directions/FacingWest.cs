namespace MarsRover
{
    public class FacingWest : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.West;

        public ICardinalDirection GetLeftDirection()
        {
            return new FacingSouth();
        }

        public ICardinalDirection GetRightDirection()
        {
            return new FacingNorth();
        }

        public ISquare GetSquareLocationInfront(ISquare currentSquare, IGrid grid)
        {
            var newColumn = (currentSquare.Column - 1).Equals(0) ? grid.Columns : currentSquare.Column - 1;
            return grid.Find(currentSquare.Row, newColumn);
        }

        public ISquare GetSquareLocationBehind(ISquare currentSquare, IGrid grid)
        {
            var newColumn = (currentSquare.Column + 1 > grid.Columns) ? 1 : currentSquare.Column + 1;
            return grid.Find(currentSquare.Row, newColumn);
        }
    }
}