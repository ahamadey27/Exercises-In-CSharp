using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    //user adds three numbers to an array and program finds greatest number
    public static class FlowControl_GreatestNumber
    {
        public static void GreatestNumber()
        {
            int[] userNumbers = new int[3];
            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int greatesNumber = userNumbers.Max();
            Console.WriteLine($"The greatest number is: {greatesNumber}");
        }
    }
}
