using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    //Create a C# program that asks the user for a text (x) and converts to check if the text is a number
    public static class DataTypesB_CheckIfNumber
    {
        public static void NumberCheck()
        {
            Console.WriteLine("Enter a number");
            string x = Console.ReadLine();

            try
            {
                Convert.ToInt32(x);
                Console.WriteLine($"{x} is a number");
            }
            catch
            {
                Console.WriteLine($"{x} is not a number");
            }

        }
    }
}
