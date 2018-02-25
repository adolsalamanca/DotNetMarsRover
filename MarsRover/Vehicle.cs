using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Vehicle
    {
        public int X_Point { get; private set; }
        public int Y_Point { get; private set; }

        private Coordinates _orientation;
        private readonly EdgeLimits _limits;

        public Vehicle(int xPoint, int yPoint, Coordinates orientation, EdgeLimits limits)
        {
            X_Point = xPoint;
            Y_Point = yPoint;
            _orientation = orientation;
            _limits = limits;
        }

        public void MoveForward()
        {
        }

        public void MoveBackward()
        {

        }

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
        }

    }
}
