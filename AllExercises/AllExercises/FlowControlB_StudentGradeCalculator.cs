using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class FlowControlB_StudentGradeCalculator
    {
        public static void GradeCalc()
        {
            Console.WriteLine("Enter a grade of student between .1 and 10");

            decimal grade;

            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out grade))
                {
                    Console.WriteLine("Enter a valid decimal");
                }

                if (grade > 0.1m && grade <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{grade} is not between 0.1 and 10. Please try again.");
                }

            }
            Console.WriteLine();

            if (grade >= 9.5m)
            {
                Console.WriteLine("A+");
            }
            else if (grade >= 9)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 8.5m)
            {
                Console.WriteLine("B+");
            }
            else if (grade >= 8)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 7.5m)
            {
                Console.WriteLine("C+");
            }
            else if (grade >= 7)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 6.5m)
            {
                Console.WriteLine("D+");
            }
            else if (grade >= 6)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }




        }
    }
}
