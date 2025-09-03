using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    //Function takes one int parameter and tells if its positive or negative 
    public static class FlowControl_PositiveOrNegative
    {
        public static void PostiveOrNegative(int x)
        {
            if (x > 0)
            {
                Console.WriteLine($"{x} is a positive number");
            }
            else
            {
                Console.WriteLine($"{x} is a negative number");
            }
        }
    }
}
