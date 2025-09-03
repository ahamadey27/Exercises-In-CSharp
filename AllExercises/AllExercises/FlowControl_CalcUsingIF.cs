using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    public static class FlowControl_CalcUsingIF
    {
         public static void Calculator()
        {
            int intA, intB;
            char operation;

            Console.WriteLine("Enter first number.");
            intA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter arithmetic.");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter second number.");
            intB = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
            {
                Console.WriteLine($"{intA} {operation} {intB} = {intA + intB}");
            }
            else if (operation == '-')
            {
                Console.WriteLine($"{intA} {operation} {intB} = {intA - intB}");
            }
            else if (operation == '*')
            {
                Console.WriteLine($"{intA} {operation} {intB} = {intA * intB}");
            }
            else if (operation == '/')
            {
                try
                {
                    int result = intA / intB;
                    Console.WriteLine($"{intA} {operation} {intB} = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Error: Cannot divide by zero " + ex);
                }
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }

        }
    }
}
