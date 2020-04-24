using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnetLab8
{
    class ForZV3
    {
        public double CircleD(double r)
        {
            if (r >= 0)
                return 2 * Math.PI * r;
            else
                throw new FormatException("radius must be more then zero, for func CircleD");
        }

        public double CircleS(double r)
        {
            if (r >= 0)
                return  Math.PI * r * r;
            else
                throw new FormatException("radius must be more then zero, for func CircleS");
        }
        public double CircleV(double r)
        {
            if (r >= 0)
                return (4.0/3.0)*Math.PI * r * r * r;
            else
                throw new FormatException("radius must be more then zero, for func CircleV");
        }
    }
}
