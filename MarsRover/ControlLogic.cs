using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;

namespace MarsRover
{
    public class ControlLogic
    {
        private Vehicle _ghost;
        private Vehicle _spaceCraft;
        private EdgeLimits _limits;
        private List<Obstacle> _obstacles;

        public ControlLogic(Vehicle spaceCraft, EdgeLimits limits, List<Obstacle> obstacles)
        {
            _spaceCraft = spaceCraft;
            _limits = limits;
            _obstacles = obstacles;
            _ghost = new Vehicle(_spaceCraft.X_Point, _spaceCraft.Y_Point, _spaceCraft.Direction);

        }

        public void ExecuteCommands(List<Command> commandList)
        {
            foreach (Command command in commandList)
            {
                try
                {
                        Execute(command);
                }
                catch (ApplicationException)
                {
                    System.Diagnostics.Debug.WriteLine(
                        "Could not go to the desired position due to map limits or an obstacle, execution sequence stopped");
                    break;
                }
                catch (ArgumentException)
                {
                    System.Diagnostics.Debug.WriteLine(
                        "Invalid command entered");
                }
            }
        }

        private void Execute(Command command)
        {
            switch (command)
            {
                case Command.F:
                    _ghost.MoveForward();
                    if (ValidateMovement())
                    {
                        _spaceCraft.MoveForward();
                    }

                    break;

                case Command.B:
                    _ghost.MoveBackward();
                    if (ValidateMovement())
                    {
                        _spaceCraft.MoveBackward();
                    }
                    
                    break;

                case Command.L:
                    _spaceCraft.TurnLeft();
                    break;

                case Command.R:
                    _spaceCraft.TurnRight();
                    break;

                default:
                    throw (new ArgumentException());
            }
        }

        private bool ValidateMovement()
        {
            if (_obstacles.Contains(new Obstacle(_ghost.X_Point, _ghost.Y_Point)) ||
                    _ghost.X_Point == _limits.EdgeX_LowerLimit || _ghost.X_Point == _limits.EdgeX_UpperLimit ||
                    _ghost.Y_Point == _limits.EdgeY_UpperLimit || _ghost.Y_Point == _limits.EdgeY_LowerLimit)
            {
                ReturnGhostCraftToPreviousState();

                throw (new ApplicationException());
            }

            return true;
        }

        private void ReturnGhostCraftToPreviousState()
        {
            _ghost.X_Point = _spaceCraft.X_Point;
            _ghost.Y_Point = _spaceCraft.Y_Point;
            _ghost.Direction = _spaceCraft.Direction;
        }

    }
}