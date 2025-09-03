using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class FlowControl_GreatestNumber
    {
        public static void GreatestNumber()
        {
            int[] userNumbers = new int[3];
            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine($"Enter number {userNumbers.Length + 1}");
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int greatesNumber = userNumbers.Max();
            Console.WriteLine($"The greatest number is: {greatesNumber}");
        }
    }
}
