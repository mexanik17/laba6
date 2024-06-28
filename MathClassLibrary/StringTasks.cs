using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public static class StringTasks
    {
        public static string GetFirstNUppercaseLetters(int n)
        {
            if (n < 1 || n > 26)
                throw new ArgumentException("N must be between 1 and 26");

            return new string(Enumerable.Range('A', n).Select(x => (char)x).ToArray());
        }

        public static int SumOfDigits(string number)
        {
            if (string.IsNullOrEmpty(number) || number.Any(c => !char.IsDigit(c)))
                throw new ArgumentException("Input must be a non-empty string of digits");

            return number.Sum(c => c - '0');
        }
    }
}

