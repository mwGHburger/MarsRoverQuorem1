using System.Collections.Generic;

namespace MarsRover
{
    public class Grid
    {
        private int _rows;
        private int _columns;

        public List<Square> Squares { get; } = new List<Square>();

        public Grid(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            CreateSquares();
        }

        private void CreateSquares()
        {
            for(var row = 1; row <= _rows; row++)
            {
                for(var column = 1; column <= _columns; column++)
                {
                    Squares.Add(new Square(row, column));
                }
            }
        }
    }
}