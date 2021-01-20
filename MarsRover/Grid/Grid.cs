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

        public ISquare Find(int row, int column)
        {
            return Squares.Find(x => x.Row.Equals(row) && x.Column.Equals(column));
        }

        private void CreateSquares()
        {
            for(var row = 1; row <= Rows; row++)
            {
                for(var column = 1; column <= Columns; column++)
                {
                    Squares.Add(new Square(row, column));
                }
            }
        }
    }
}