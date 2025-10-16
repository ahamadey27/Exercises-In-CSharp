using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class FlowControlC_ConditionalOperator
    {
        public static void Conditional()
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

                while(true)
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

            Console.WriteLine(x > 0 ? $"{x} is positive" : $"{x} is negative.");
            Console.WriteLine(y > 0 ? $"{y} is positive" : $"{y} is negative.");
            Console.WriteLine((x > 0) && (y > 0) ? $"{x} and {y} are positive" : $"{x} and {y} are not both positive.");

        }
    }
}
