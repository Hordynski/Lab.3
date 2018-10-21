using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._3
{
    class Program
    {
        private object userName;

        static void Main(string[] args)
        {
            bool doAgain = true;

            Console.Write($"Hello user! How would you like to be addressed? ");
            var userName = Console.ReadLine();

            while (doAgain == true)
            {
                Console.Write($"Thank you {userName}! Now please enter a number between 1 and 100: ");
                var userNumber = Int16.TryParse(Console.ReadLine(), out short j);

                if (j >= 1 && j <= 100 && userNumber == true)
                {
                    var k = j % 2;
                    if (j >= 2 && j <= 25 && k == 0)
                    {
                        Console.WriteLine($"{userName}, your number is even and less than 25.");
                    }

                    else if (j >= 26 && j <= 60 && k == 0)
                    {
                        Console.WriteLine($"{userName}, your number is even.");
                    }

                    else if (j > 60 && k == 0)
                    {
                        Console.WriteLine($"{userName}, your number is {j} and is even.");
                    }

                    else if (k != 0)
                    {
                        Console.WriteLine($"{userName}, your number is {j} and is odd.");
                    }
                }

                else
                {
                    Console.WriteLine($"I'm sorry {userName}, I do not recognize that input.");
                }

                Console.Write("Would you like to run this program again? Y or N: ");
                string userRepeat = Console.ReadLine();

                if (userRepeat.StartsWith("y") || userRepeat.StartsWith("Y"))
                {
                    doAgain = true;
                }

                else
                {
                    doAgain = false;
                }
            }
        }
    }
}
