using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_Root
{
    class SquareRoot
    {
        public static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }

            return Math.Sqrt(value);
        }

    }
}
