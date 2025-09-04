using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    //Create a program in C# that requests a number (x) and displays 10*x. Must be repeated until user enters 0.
    public static class FlowControl_DoWhile
    {
        public static void DoWhile()
        {
            int x = 0;

            do
            {
                Console.WriteLine("Enter a number");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x * 10);
            }

            while (x != 0);
        }

    }
}
