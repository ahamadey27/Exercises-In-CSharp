using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    /*Create a C# program that asks the user for two integers (x, y) and shows the range of those numbers (the two included), in three different ways:

        . Using the for statement.
        . Using the while statement.
        . Using the do while instruction.
    */
    public static class FlowControlB_RepetitiveStructures
    {
        public static void NumRange()
        {
            int x, y;
            

            Console.WriteLine("Enter two digits");

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

            int i;
           

            for (i = x; i <= y; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            i = x;
            while (i <= y)
            {
                Console.Write($"{i} ");
                i++;
            }

            Console.WriteLine();

            i = x;
            do
            {
                Console.Write($"{i} ");
                i++;
            }
            while (i <= y);

        }
    }
}
