namespace MarsRover
{
    public class Rover
    {
        public ICardinalDirection CurrentFacingDirection { get; private set; }
        public Square CurrentSquareLocation { get; set; }
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

        public void MoveForward(Grid grid)
        {
            CurrentSquareLocation = CurrentFacingDirection.GetSquareLocationInfront(CurrentSquareLocation,grid);
        }
    }
}