namespace MarsRover
{
    public interface IRover
    {
        ISquare CurrentSquareLocation { get; set; }
        ICardinalDirection CurrentFacingDirection { get; }
        void TurnLeft();
        void TurnRight();
        void MoveForward(IGrid grid);
        void MoveBackwards(IGrid grid);
        void DetectObstacleInfront(IGrid grid);
        void DetectObstacleBehind(IGrid grid);
    }
}