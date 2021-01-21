using System.Collections.Generic;

namespace MarsRover.Tests
{
    public static class TestHelper
    {
        public static IGrid SetupGrid()
        {
            return new Grid(4,4);
        }

        public static List<ISquare> SetupSquares()
        {
            var squares = new List<ISquare>();

            for(var i = 1;i < 4; i++)
            {
                for(var j = 1;j < 4; j++)
                {
                    squares.Add(new Square(i,j));
                }
            }
            return squares;
        }
    }
}