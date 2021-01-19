using System;
using Xunit;

namespace MarsRover.Tests
{
    public class GridTests
    {
        [Fact]
        public void Grid_ShouldHaveSquaresWhenConstructed()
        {
            var grid = new Grid(4,4);

            var actual = grid.Squares.Count;

            Assert.Equal(16, actual);
        }
    }
}
