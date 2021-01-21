namespace MarsRover
{
    public class GridDisplay : IGridDisplay
    {
        private IGrid _grid;
        private IRover _rover;

        public GridDisplay(IGrid grid, IRover rover)
        {
            _grid = grid;
            _rover = rover;
        }
        public string GetGridAsString()
        {
            var gridString = "";
            var gridRow = "";
            foreach(ISquare square in _grid.Squares)
            {
                if(square.Column < _grid.Columns)
                {
                    gridRow += GetIcon(square);
                }
                else
                {
                    gridRow += GetIcon(square);
                    gridString = "\n" + gridRow + gridString;
                    gridRow = "";
                }
            }
            return gridString;
        }
        
        private string GetIcon(ISquare square)
        {
            if(_rover.CurrentSquareLocation.Equals(square))
            {
                switch(_rover.CurrentFacingDirection.Name)
                {
                    case DirectionName.North:
                        return "🔼";
                    case DirectionName.East:
                        return "⏩";
                    case DirectionName.South:
                        return "🔽";
                    case DirectionName.West:
                        return "⏪";
                }
            }
            
            switch(square.SquareState)
            {
                case SquareState.Empty:
                    return "🟥";
                case SquareState.Not_Empty:
                    return "🌋";  
                default:
                    return "";  
            }
        }
    }
}