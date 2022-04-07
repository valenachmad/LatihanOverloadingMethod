using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        private int _a, _b;
        int min, max;
        public int FindMinimum(int number1, int number2)
        {
            min = number2;
            if (min > number1)
            {
                min = number1;
            }
            return min;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            if (number1 < number2 && number1 < number3)
            {
                min = number1;
            }
            else if (number2 < number3)
            {
                min = number2;
            }
            else
            {
                min = (int)number3;
            }
            return min;
        }

        public int FindMaximum(int number1, int number2)
        {
            max = number1;
            if (max < number2)
            {
                max = number2;
            }
            return max;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                max = number1;
            }
            else if (number2 > number3)
            {
                max = number2;
            }
            else
            {
                max = (int)number3;
            }
            return max;
        }
    }
}