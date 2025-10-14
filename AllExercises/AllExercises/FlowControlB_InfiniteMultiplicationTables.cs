using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class FlowControlB_InfiniteMultiplicationTables
    {
        public static void MultTables()
        {
            int x, y;

            // Loop until both x and y are assigned valid integer values
            while (true)
            {
                Console.Write("Enter first number: ");
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Enter a valid integer");
                    continue;
                }

                while (true)
                {
                    Console.Write("Enter second number: ");
                    if (int.TryParse(Console.ReadLine(), out y))
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid integer");
                    }
                }
               

                // Both x and y are assigned, break out of loop
                break;
            }

            Console.WriteLine();

            for (int i = 1; i < 11; i++)
            {
                int xAnswer = x * i;
                Console.WriteLine($"{x}x{i}= {xAnswer}");
            }

            Console.WriteLine();

            for (int j = 1; j < 11; j++)
            {
                int yAnswer = y * j;
                Console.WriteLine($"{y}x{j}= {yAnswer}");
            }
        }
    }
}
