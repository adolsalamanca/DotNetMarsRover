namespace MarsRover.Direction
{
    public class EastDirection : IDirection
    {
        public void MoveForward(Vehicle spaceCraft)
        {
            spaceCraft.X_Point++;
        }

        public void MoveBackward(Vehicle spaceCraft)
        {
            spaceCraft.X_Point--;
        }

        public IDirection TurnLeft()
        {
            return new NorthDirection();
        }

        public IDirection TurnRight()
        {
            return new SouthDirection();
        }
    }
}