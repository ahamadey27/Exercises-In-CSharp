using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    internal static class FlowContralB_NumberRepeated
    {

        //Write a program in C# that asks for a number (x) and a amount (y). Show that number as many times as the amount (y).
        public static int NumRepeat()
        {
            int repeatedNumber = 0;

            Console.WriteLine("Enter number X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number Y");
            int y = Convert.ToInt32(Console.ReadLine());

            while (repeatedNumber < y)
            {
                Console.Write(x);
                repeatedNumber++;
            }

            return repeatedNumber;

            



        }
    }
}
