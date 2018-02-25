using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Direction;
using NUnit.Framework;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Command> listCommands = new List<Command>();

            foreach (string arg in args)
            {
                Command command;
                try
                {
                    Enum.TryParse(arg, out command);
                    listCommands.Add(command);
                }
                catch (Exception)
                {
                    System.Diagnostics.Debug.WriteLine("Invalid command entered");
                }

            }

            EdgeLimits limits = new EdgeLimits(6456,2342,3451,1232);
            Vehicle spaceCraft = new Vehicle(0,0,new NorthDirection());
            List<Obstacle> obstacleList = new List<Obstacle>()
            {
                new Obstacle(333,222),
                new Obstacle(123,456)
            };
            ControlLogic logic = new ControlLogic(spaceCraft, limits, obstacleList);

            logic.ExecuteCommands(listCommands);



        }
    }
}
