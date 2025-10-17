using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    //Create a C# program that asks the user for a letter (x) and check if it is a vowel or other symbol.
    public static class DataTypesB_VowelCheck
    {
        public static void VowelCheck()
        {
            Console.WriteLine("Enter a letter to check if its a vowel.");

            char word;

            while (true)
            {
                if (!char.TryParse(Console.ReadLine(), out word))
                {
                    Console.WriteLine("Enter a valid character");
                    continue;
                }

                break;
            }

            word = char.ToLower(word);

            switch(word)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    Console.WriteLine($"{word} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{word} is not a vowel");
                    break;
            }

        }
    }
}
