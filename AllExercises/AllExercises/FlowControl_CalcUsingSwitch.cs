using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    //Calculator using switch statement
    public static class FlowControl_CalcUsingSwitch
    {
        public static void Calculator()
        {
            int intA, intB;
            char operation;

            Console.Write("Enter first number: ");
            intA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter arithmetic: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            intB = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{intA} {operation} {intB} = {intA + intB}");
                    break;
                case '-':
                    Console.WriteLine($"{intA} {operation} {intB} = {intA - intB}");
                    break;

                case '*':
                    Console.WriteLine($"{intA} {operation} {intB} = {intA * intB}");
                    break;
                case '/':
                    try
                    {
                        decimal resultDivide = intA / intB;
                        Console.WriteLine($"{intA} {operation} {intB} = {intA / intB}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Error: Cannot divide by zero: " + ex);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}
