using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class FlowControlC_PrimeNumber
    {
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a number");
            int x;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Enter a valid integer");
                    continue; 
                }
                break;
            }

            int y = int.Abs(x);
            int divider = 2;

            while (y % divider != 0)
            {
                divider++;
            }

            if (divider == y)
            {
                Console.WriteLine($"{y} is prime");
            }
            else
            {
                Console.WriteLine($"{y} is not prime");
            }
            


            


        }
    }
}
