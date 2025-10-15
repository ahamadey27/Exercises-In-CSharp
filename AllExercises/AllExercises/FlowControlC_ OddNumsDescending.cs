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
            int x, y;

            Console.WriteLine("Enter first digit");
            
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Enter a valid integer");
                    continue;
                }

                Console.WriteLine("Enter a second integer");

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out y))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid integer");
                    }
                }

                break;
            }

            for (int i = x - 1; i >= y; i--)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
                
            }
            
              
        }
    }
}
