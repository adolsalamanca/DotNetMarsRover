using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class EdgeLimits
    {
        public int EdgeX_LowerLimit { get; }
        public int EdgeX_UpperLimit { get; }
        public int EdgeY_LowerLimit { get; }
        public int EdgeY_UpperLimit { get; }

        public EdgeLimits(int xLowerLimit, int xUpperLimit, int yLowerLimit, int yUpperLimit)
        {
            EdgeX_LowerLimit = xLowerLimit;
            EdgeX_UpperLimit = xUpperLimit;
            EdgeY_LowerLimit = yLowerLimit;
            EdgeY_UpperLimit = yUpperLimit;
        }

    }
}
