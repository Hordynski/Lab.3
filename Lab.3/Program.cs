using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._3
{
    class Program
    {
        // James - I see you are cranking out the ol' Field! so in this field, "object" is the type,
        // for type safety, and for avoiding boxing/unboxing, I would type out your field like 
        //
        // private string _userName;
        //
        // notice the "_" underscore in front of the name, and that I am using of type string.
        // the the underscore is a popular naming convention when naming private fields, lets the devleoper 
        // know later that you are dealing with a private field when you are like 70 lines in
        private object userName;

        static void Main(string[] args)
        {
            bool doAgain = true;

            Console.Write($"Hello user! How would you like to be addressed? ");
            var userName = Console.ReadLine();

            // James - not sure if I mentioned this before, not that theres anything wrong with typing
            // doAgain == true, but you can also just put
            // while (doAgain)
            // but if you knew that and you feel that it is more readable to explicity check for true, 
            // then there is nothing wrong with that, it's whatever is more readable to you and your team :)
            while (doAgain == true)
            {
                Console.Write($"Thank you {userName}! Now please enter a number between 1 and 100: ");
                // James - oooo, I see you are using int16, aka a short instead of int.TryParse! thats 
                // awesome.  this is totally valid since you know the number range is not greater than 
                // 32767, this makes your code more effecient, it's a micro improvement, but still an 
                // improvement none the less.  just for future refence though, instead of using the
                // .Net Framework 4.6 type of Int16, I would use short.  short is the C# version of 
                // the .Net Framework Int16, and the c# version will ALWAYS point to the proper struct.
                var userNumber = Int16.TryParse(Console.ReadLine(), out short j);

                // James - what is j? I would rename your variable to something more human readable.
                // though in this case it's for the most part clear that it's just the variable that is being
                // parsed, it makes a huge difference to use good naming conventions when reading like 
                // tens of thousands of lines a code. 
                // 
                // Also pro tip, if TryParse returns false, the out short j by default will == 0.  so this 
                // means your condition here is checking "j" first, but it has a chance of being 0!
                // a good way to avoid this is to check if the userNumber boolean is true first.  that way if it 
                // userNumber is false, your condition expression will short circuit and not check the potential "0" values.
                // 
                // also I know it's a bit redundant since it will be false regardless, but its important you understand 
                // when to use order of evaluation and understanding the default values of value types.
                if (j >= 1 && j <= 100 && userNumber == true)
                {
                    // James - overall, the spacing and lines of this code makes it way more readable
                    // I'm seeing real improvement!
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

                // James - cool, I really like that you are using new methods here, StartsWith is 
                // a pretty cool way to handle this. but just so you know, this method takes a second argument,
                // the handly StringComparison.OrdinalIgnoreCase enum.  so you can essentially do this in one method 
                // call instead of 2 like this: 
                //
                // userRepeat.StartsWith("y", StringComparison.OrdinalIgnoreCase)
                //
                // This wil ignore if the y is lower or upper case, this saves computation time from
                // calling a method twice.
                if (userRepeat.StartsWith("y") || userRepeat.StartsWith("Y"))
                {
                    doAgain = true;
                }
                // James - I actually really like that you put a line between these two condition block, makes it 
                // more readable.
                else
                {
                    doAgain = false;
                }
            }
        }
    }
}
