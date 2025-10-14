using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class InfiniteMultiplicationTables
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

                Console.Write("Enter second number: ");
                if (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Enter a valid integer");
                    continue;
                }

                // Both x and y are assigned, break out of loop
                break;
            }

            for (int i = 1; i < 11; i++)
            {
                int xAnswer = x * i;
                Console.WriteLine($"{x}x{i}= {xAnswer}");
            }

            for (int j = 1; j < 11; j++)
            {
                int yAnswer = y * j;
                Console.WriteLine($"{y}x{j}= {yAnswer}");
            }
        }
    }
}
