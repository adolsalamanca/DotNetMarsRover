namespace MarsRover.Direction
{
    public class WestDirection : IDirection
    {
        public void MoveForward(Vehicle spaceCraft)
        {
                spaceCraft.X_Point--;
        }

        public void MoveBackward(Vehicle spaceCraft)
        {
                spaceCraft.X_Point++;
        }

        public IDirection TurnLeft()
        {
            return new SouthDirection();
        }

        public IDirection TurnRight()
        {
            return new NorthDirection();
        }
    }
}