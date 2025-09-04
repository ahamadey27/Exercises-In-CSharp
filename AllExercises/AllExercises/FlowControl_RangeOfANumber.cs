using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    //Range of numbers from starting x parameter to length of y parameter 
    public static class FlowControl_RangeOfANumber
    {
        public static void NumberRange(int x, int y)
        {
            for (int i = x; i <= y; i++)
            {
                Console.Write($"{i},");
            }
        }

    }
}
