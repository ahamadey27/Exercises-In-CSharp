using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class FlowControlC_ConditionalNested
    {
        //Create a C# program that asks the user for two integers (a, b) and check how many of them are positive.
        public static void ConditionNested()
        {
            int x, y;

            Console.WriteLine("Enter two integers");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Enter a valid integer");
                    continue;
                }

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



        }
    }
}
