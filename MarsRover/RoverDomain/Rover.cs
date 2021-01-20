namespace MarsRover
{
    public class Rover : IRover
    {
        private IObstacleDetector _obstacleDetector;

        public ICardinalDirection CurrentFacingDirection { get; private set; }
        public ISquare CurrentSquareLocation { get; set; }
        public Rover(ICardinalDirection currentFacingDirection, IObstacleDetector obstacleDetector)
        {
            _obstacleDetector = obstacleDetector;
            CurrentFacingDirection = currentFacingDirection;
        }

        public void TurnLeft()
        {
            CurrentFacingDirection = CurrentFacingDirection.TurnLeft();
        }

        public void TurnRight()
        {
            CurrentFacingDirection = CurrentFacingDirection.TurnRight();
        }

        public void MoveForward(IGrid grid)
        {
            CurrentSquareLocation = CurrentFacingDirection.GetSquareLocationInfront(CurrentSquareLocation, grid);
        }

        public void MoveBackwards(IGrid grid)
        {
            CurrentSquareLocation = CurrentFacingDirection.GetSquareLocationBehind(CurrentSquareLocation, grid);
        }

        public void DetectObstacleInfront(IGrid grid)
        {
            _obstacleDetector.AssessSquareInfront(CurrentFacingDirection, CurrentSquareLocation, grid);
        }

        public void DetectObstacleBehind(IGrid grid)
        {
            _obstacleDetector.AssessSquareBehind(CurrentFacingDirection, CurrentSquareLocation, grid);
        }
    }
}