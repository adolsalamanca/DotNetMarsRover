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
        private readonly EdgeLimits _limits;

        public Vehicle(int xPoint, int yPoint, IDirection direction, EdgeLimits limits)
        {
            X_Point = xPoint;
            Y_Point = yPoint;
            Direction = direction;
            _limits = limits;
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
        }

        public void TurnRight()
        {
        }

    }
}
