namespace MarsRover.Direction
{
    public class NorthDirection : IDirection
    {
        public void MoveForward(Vehicle spaceCraft)
        {
                spaceCraft.Y_Point++;
        }

        public void MoveBackward(Vehicle spaceCraft)
        {
                spaceCraft.Y_Point--;
        }

        public IDirection TurnLeft()
        {
            return new WestDirection();
        }

        public IDirection TurnRight()
        {
            return new EastDirection();
        }
    }
}