using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassLibrary
{
    public class Geometry
    {
        public int CalculateArea(int length, int width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("The dimensions must be positive numbers.");
            }
            return length * width;
        }
    }
}
