namespace MarsRover
{
    public interface IRover
    {
        void TurnLeft();
        void TurnRight();
        void MoveForward(IGrid grid);
        void MoveBackwards(IGrid grid);
        void DetectObstacleInfront(IGrid grid);
        void DetectObstacleBehind(IGrid grid);
    }
}