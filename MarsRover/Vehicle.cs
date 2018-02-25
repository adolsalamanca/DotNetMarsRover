using MarsRover.Direction;

namespace MarsRover
{
    public class Vehicle
    {
        public int X_Point { get; set; }
        public int Y_Point { get; set; }
        public IDirection Direction { get; set; }

        public Vehicle(int xPoint, int yPoint, IDirection direction)
        {
            X_Point = xPoint;
            Y_Point = yPoint;
            Direction = direction;
        }

        public void MoveForward()
        {
            Direction.MoveForward(this);
        }

        public void MoveBackward()
        {
            Direction.MoveBackward(this);
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

    }
}
