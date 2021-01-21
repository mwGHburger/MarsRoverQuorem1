using System;

namespace MarsRover
{
    public class ObstacleSetup : ISetup
    {
        private IGrid _grid;
        private IRandomiser _randomiser;

        public ObstacleSetup(IGrid grid, IRandomiser randomiser)
        {
            _grid = grid;
            _randomiser = randomiser;
        }

        public void Setup()
        {
            var maximumNumberOfObstacles = ApplicationProperties.NumberOfObstacles;
            for(var i = 1; i < maximumNumberOfObstacles; i++)
            {
                var emptySquares = _grid.Squares.FindAll(x => x.SquareState.Equals(SquareState.Empty));
                var randomIndex = _randomiser.GetRandomNumber(emptySquares.Count);
                var randomEmptySquare = emptySquares[randomIndex];
                randomEmptySquare.SquareState = SquareState.Not_Empty;
            }
        }
    }
}