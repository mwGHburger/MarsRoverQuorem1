using System;

namespace MarsRover
{
    public class ObstacleSetup : ISetup
    {
        private IGrid _grid;

        public ObstacleSetup(IGrid grid)
        {
            _grid = grid;
        }

        public void Setup(IUserInterface userInterface)
        {
            userInterface.Print("Creating obstacles...");
            var random = new Random();
            var maximumNumberOfObstacles = ApplicationProperties.NumberOfObstacles;
            System.Console.WriteLine(maximumNumberOfObstacles);
            for(var i = 1; i < maximumNumberOfObstacles; i++)
            {
                var emptySquares = _grid.Squares.FindAll(x => x.SquareState.Equals(SquareState.Empty));
                var randomIndex = random.Next(i, emptySquares.Count);
                var randomEmptySquare = emptySquares[randomIndex];
                randomEmptySquare.SquareState = SquareState.Not_Empty;
            }
        }
    }
}