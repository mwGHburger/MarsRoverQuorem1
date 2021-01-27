using System.Collections.Generic;

namespace MarsRover
{
    public interface IGrid
    {
        int Rows { get; }
        int Columns { get; }
        ISquare FindSquare(int row, int column);
        List<ISquare> Squares { get; }
    }
}