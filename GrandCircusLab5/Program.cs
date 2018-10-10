using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long userNumber;
                Console.WriteLine("Welcome to the Factorial Calculator!");

                while (true)
                {
                    Console.Write("Please enter a number between 1 and 10: ");
                    string userChoice = Console.ReadLine();

                    if (long.TryParse(userChoice, out userNumber))
                    {
                        if (userNumber > 10 || userNumber < 1)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                long factorialNumber = GetFactorial(userNumber);

                Console.WriteLine("\n\nThe factorial of {0} is {1}", userNumber, factorialNumber);

                Console.WriteLine("\n\nType 'y' to go again!");

                char check = Console.ReadKey(true).KeyChar;

                if (check != 'y' && check != 'Y')
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }

        static long GetFactorial (long userNumber)
        {
            if (userNumber == 0) //at 1, 1 - 1 would be zero but we just want 1
            {
                return 1; // so we return 1 instead
            }
            return (userNumber * GetFactorial(userNumber - 1)); //set the method to the number, call again - 1
        }
    }
}
