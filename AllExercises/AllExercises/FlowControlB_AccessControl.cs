using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExercises
{
    //Write an access control in C# that asks the user for the username and password. Both must be integers and repeat until the login is 12 and the password is 1234 or up to a maximum of 3 attempts.
    public static class FlowControlB_AccessControl
    {
        public static void AccessCntrl()
        {
            const int correctUser = 12;
            const int correctPassword = 1234;
            int attempts = 0;
            int maxAttempts = 3;
            int user, password;

            while (attempts < maxAttempts)
            {

                Console.Write("User Name: ");
                if (!int.TryParse(Console.ReadLine(), out user))
                {
                    Console.WriteLine("Invalid input. Enter integer;");
                    continue;
                }

                Console.Write("User Password: ");
                if (!int.TryParse(Console.ReadLine(), out password))
                {
                    Console.WriteLine("Invalid input. Enter integer;");
                    continue;
                }

                if ((user == correctUser) && (password == correctPassword))
                {
                    Console.WriteLine("Login Success");
                }

                attempts++;
                

                Console.WriteLine($"Login {attempts} failed...\n {maxAttempts - attempts} left ");

            }

            Console.WriteLine("Maximum attempts reached. Access denied.");
        }
    }
}
