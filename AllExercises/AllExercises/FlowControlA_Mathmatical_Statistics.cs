using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    /* 
      Create a C# program that prompts the user for 5 integers and displays the following mathematical statistics on the screen:
        The sum of the 5 numbers
        The arithmetic mean
        The maximum number
        The minimum number
    */
    public static class FlowControlA_Mathmatical_Statistics
    {
        public static void StatsReturn(int[] numbers)
        {
            int total = numbers.Length;

            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i;
            }

            decimal average = sum / total; 
            int min = numbers.Min();
            int max = numbers.Max();

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");

        }


    }
}
