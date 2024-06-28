using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public static class YearTasks
    {
        public static int GetDaysInYear(int year)
        {
            if (year <= 0)
                throw new ArgumentException("Год должен быть положительным целым числом.");

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return 366;
            }
            return 365;
        }
    }
}

