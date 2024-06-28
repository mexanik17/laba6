using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public static class MathTasks
    {
        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("Coefficient a must not be zero");

            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double sqrtD = Math.Sqrt(discriminant);
                return new double[]
                {
                    (-b + sqrtD) / (2 * a),
                    (-b - sqrtD) / (2 * a)
                };
            }
            if (discriminant == 0)
            {
                return new double[] { -b / (2 * a) };
            }
            return new double[] { };
        }

        public static double Integrate(Func<double, double> function, double lower, double upper, double step = 0.01)
        {
            double result = 0.0;
            for (double x = lower; x < upper; x += step)
            {
                result += function(x) * step;
            }
            return result;
        }
    }
}

