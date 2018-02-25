namespace MarsRover.Direction
{
    public class SouthDirection : IDirection
    {
        public void MoveForward(Vehicle spaceCraft)
        {
                spaceCraft.Y_Point--;
        }

        public void MoveBackward(Vehicle spaceCraft)
        {
                spaceCraft.Y_Point++;
        }

        public IDirection TurnLeft()
        {
            return new EastDirection();
        }

        public IDirection TurnRight()
        {
            return new WestDirection();
        }
    }
}