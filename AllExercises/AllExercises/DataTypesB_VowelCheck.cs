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
                string input = Console.ReadLine();
                if (input.Length == 1 && char.TryParse(input, out word) && char.IsLetter(word))
                {
                    break;
                }

                Console.WriteLine($"{input} is not a valid charecter");
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
