using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment_for_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNum;
            int startNum, endNum;
            int userGuess = -1;
            int guessCounter = 0;
            string winMessage;

            Console.Write("Enter a starting number: ");
            startNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an ending number: ");
            endNum = Convert.ToInt32(Console.ReadLine());
            secretNum = rand.Next(startNum, endNum);
            Console.WriteLine("I'm thinking of a number between " + startNum + " and " + endNum + ".");
            while (userGuess != secretNum)
            {
                Console.Write("Guess: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess < secretNum)
                {
                    Console.WriteLine("Too low.");
                }
                else if (userGuess > secretNum)
                {
                    Console.WriteLine("Too high.");
                }
                guessCounter += 1;
            }
            winMessage = String.Format("You won in {0} guesses!", guessCounter);
            Console.WriteLine(winMessage);

            Console.WriteLine("Enter anything to exit.");
            Console.ReadLine();
        }
    }
}
