using System.Collections.Generic;

namespace MarsRover
{
    public class Obstacle
    {
        public int X_Point { get; }
        public int Y_Point { get; }

        public Obstacle(int point_x, int point_y)
        {
            X_Point = point_x;
            Y_Point = point_y;
        }
    }
}
