using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string password;
            bool correctPassword = false;
            int min = 7;
            int max = 12;
            string exclamation = "!";


            //Password instructions
            Console.WriteLine("Hello, please create a password with the following requirements: \n ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     - At least one lowercase letter");
            Console.WriteLine("     - At least one uppercase letter");
            Console.WriteLine("     - At least minimum 7 characters");
            Console.WriteLine("     - At least maximum 12 characters");
            Console.WriteLine("     - An exclamation point: !");

            //Start loop here
            while (correctPassword == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nEnter your password here: ");
                password = Console.ReadLine();

                if (correctPassword == password.Any(char.IsLower))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, does not contain one lowercase letter");
                }
                else if (correctPassword == password.Any(char.IsUpper))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, does not contain one uppercase letter");
                }
                else if (password.Length < min)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, does not meet character requirement");

                }
                else if (password.Length > max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, password exceeds character requirement");
                }
                else if (correctPassword == password.Contains(exclamation))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, does not contain an exclamation point");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Password valid and accepted");
                    correctPassword = true;
                }
            }
        }
    }
}
