using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AllExercises
{
    public static class FlowControlC__OddNumsDescending
    {
        //Create a program in C# to show odd numbers from x to y in orden descending.
        public static void OddNums()
        {
            Console.WriteLine("Enter first digit");

            int x, y;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Enter a valid integer");
                    continue;
                }

                Console.WriteLine("Enter a second integer");
            }
        }
    }
}
