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

        private IDirection _direction;
        private Coordinates _orientation;
        private readonly EdgeLimits _limits;

        public Vehicle(int xPoint, int yPoint, IDirection direction, Coordinates orientation, EdgeLimits limits)
        {
            X_Point = xPoint;
            Y_Point = yPoint;
            _direction = direction;
            _orientation = orientation;
            _limits = limits;
        }

        public void MoveForward()
        {
            _direction.MoveForward(this);
        }

        public void MoveBackward()
        {
            _direction.MoveBackward(this);
        }

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
        }

        private void MoveLogic()
        {
            switch (_orientation)
            {
                case Coordinates.North:
                    break;
                case Coordinates.South:
                    break;
                case Coordinates.East:
                    break;
                case Coordinates.West:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }




    }
}
