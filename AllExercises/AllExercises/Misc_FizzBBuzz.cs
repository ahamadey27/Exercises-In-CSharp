using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class Misc_FizzBBuzz
    {
        public static void FBuzz(int num)
        {
            bool fizz = false;
            bool buzz = false;

            for (int i = 1; i < num; i++)
            {
                fizz = i % 3 == 0;
                buzz = i % 3 == 0;

                Console.WriteLine(fizz && buzz ? "FizzBuzz" : fizz ? "fizz" : buzz ? "buzz" : i.ToString());
            }
        }
    }
}
