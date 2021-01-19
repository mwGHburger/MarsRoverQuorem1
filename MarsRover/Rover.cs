namespace MarsRover
{
    public class Rover
    {
        public ICardinalDirection CurrentFacingDirection { get; private set; }
        public Rover(ICardinalDirection currentFacingDirection)
        {
            CurrentFacingDirection = currentFacingDirection;
        }

        public void TurnLeft()
        {
            CurrentFacingDirection = CurrentFacingDirection.TurnLeft();
        }
    }
}