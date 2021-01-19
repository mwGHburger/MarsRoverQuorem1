using System;
using Xunit;

namespace MarsRover.Tests
{
    public class GridTests
    {
        [Theory]
        [InlineData(4,4,16)]
        [InlineData(3,5,15)]
        public void Grid_ShouldHaveSquaresWhenConstructed(int rows, int columns, int expected)
        {
            var grid = new Grid(rows, columns);

            var actual = grid.Squares.Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Find_ShouldReturnASquare_GivenRowAndColumnLocations()
        {
            var grid = new Grid(4,4);

            var actual = grid.Find(2,3);

            Assert.Equal(2, actual.Row);
            Assert.Equal(3, actual.Column);
        }
    }
}
