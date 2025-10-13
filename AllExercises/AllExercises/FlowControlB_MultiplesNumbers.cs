using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{

    //Create a C# program that shows numbers 1 through 500 that are multiples of 3 and also multiples of 5.
    public static class FlowControlB_MultiplesNumbers
    {
        public static void MultNumbers(int num)
        {
            for (int i = 1; i <= 500; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
