using System;
using Xunit;

namespace MarsRover.Tests
{
    public class GridTests
    {
        IGrid grid = new Grid(8,8);

        [Fact]
        public void CreateSquares_ShouldCreateListOfSquares()
        {
            var expected = 64;

            var actual = grid.Squares.Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Find_ShouldReturnASquare_GivenRowAndColumnLocations()
        {
            var actual = grid.Find(2,3);

            Assert.Equal(2, actual.Row);
            Assert.Equal(3, actual.Column);
        }
    }
}
