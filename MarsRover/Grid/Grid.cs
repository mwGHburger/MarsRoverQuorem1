using System.Collections.Generic;

namespace MarsRover
{
    public class Grid : IGrid
    {
        public int Rows { get; }
        public int Columns { get; }

        public List<ISquare> Squares { get; } = new List<ISquare>();

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            CreateSquares();
        }

        public ISquare FindSquare(int row, int column)
        {
            return Squares.Find(x => x.Row.Equals(row) && x.Column.Equals(column));
        }

        private void CreateSquares()
        {
            var smallestRow = 1;
            var smallestColumn = 1;
            for(var row = smallestRow; row <= Rows; row++)
            {
                for(var column = smallestColumn; column <= Columns; column++)
                {
                    Squares.Add(new Square(row, column));
                }
            }
        }
    }
}