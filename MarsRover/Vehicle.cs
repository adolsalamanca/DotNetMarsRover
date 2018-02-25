using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Direction;

namespace MarsRover
{
    public class Vehicle
    {
        public int X_Point { get; set; }
        public int Y_Point { get; set; }
        public IDirection Direction { get; set; }
        public EdgeLimits Limits { get; }

        public Vehicle(int xPoint, int yPoint, IDirection direction, EdgeLimits limits)
        {
            X_Point = xPoint;
            Y_Point = yPoint;
            Direction = direction;
            Limits = limits;
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
