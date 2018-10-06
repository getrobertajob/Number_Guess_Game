    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
/// <summary>
/// The author is Robert Lute
/// getrobertajob@gmail.com
/// 719-310-0055
/// 
/// This is a simple guess the numbers game displayed in the console. 
/// It displays the range that the number can be, 
///   picks a random value within that range, 
///   prompts the user for input, 
///   displays a high/lower answer to direct the user towards the answer, 
///   displays the remaining number of guesses, 
///   displays results when the user guesses correctly, 
///   and displays a different results if remaining number of guesses reaches zero. 
/// </summary>
namespace ConsoleApplication1
{
class Program
{
static void Main(string[] args)
{
            //Declare variables
            int VarCount = 20;

            //Make random answer value
            Random rnd = new Random();
            int VarAns = rnd.Next(1, 100);

            //Provide user guess range and count of attemps left
            Console.WriteLine("Guess a number between 1 - 100.");
            Console.WriteLine("You have " + VarCount + " attempts left.");

        Start:
            //Get user input
            int VarGes = Convert.ToInt32(Console.ReadLine());

            //Checks if the count of attempts is zero
            if(VarCount == 0)
            {
                Console.WriteLine("Sorry you are out of attempts.");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            //Checks if users last guess was higher than the answer
            else if ((VarGes > VarAns))
            {
                Console.WriteLine("The answer is Lower");
                Console.WriteLine("You have " + --VarCount + " attempts left.");
                goto Start;
            }
            //Checks if users last guess was lower than the answer
            else if ((VarGes < VarAns))
            {
                Console.WriteLine("The answer is Higher");
                Console.WriteLine("You have " + --VarCount + " attempts left.");
                goto Start;
            }

            //Checks if users last guess was correct
            if (VarGes == VarAns)
            {
                Console.WriteLine("Congrats you guessed correctly");
                Console.WriteLine("The answer was: " + VarAns);
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
}
}
