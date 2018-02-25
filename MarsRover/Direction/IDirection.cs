namespace MarsRover.Direction
{
    public interface IDirection
    {
        void MoveForward (Vehicle spaceCraft);

        void MoveBackward (Vehicle spaceCraft);

        IDirection TurnLeft();

        IDirection TurnRight();
    }
}