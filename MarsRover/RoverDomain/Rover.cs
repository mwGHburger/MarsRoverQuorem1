namespace MarsRover
{
    public class Rover
    {
        public ICardinalDirection CurrentFacingDirection { get; private set; }
        public ISquare CurrentSquareLocation { get; set; }
        public Rover(ICardinalDirection currentFacingDirection)
        {
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
    }
}