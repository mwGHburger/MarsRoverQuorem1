namespace MarsRover
{
    public class ObstacleDetector : IObstacleDetector
    {
        public void AssessSquareInfront(ICardinalDirection currentDirection, ISquare currentSquare, IGrid grid)
        {
            var squareInfront = currentDirection.GetSquareLocationInfront(currentSquare, grid);
            if(squareInfront.SquareState.Equals(SquareState.Not_Empty))
            {
                throw new RoverMovementException("Obstacle detected infront of Rover. Rover cannot move forward.");
            }
        }

        public void AssessSquareBehind(ICardinalDirection currentDirection, ISquare currentSquare, IGrid grid)
        {
            var squareInfront = currentDirection.GetSquareLocationBehind(currentSquare, grid);
            if(squareInfront.SquareState.Equals(SquareState.Not_Empty))
            {
                throw new RoverMovementException("Obstacle detected behind the Rover. Rover cannot move backwards.");
            }
        }
    }
}