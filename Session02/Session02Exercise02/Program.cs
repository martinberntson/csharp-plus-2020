using System;

namespace Session02Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to build a trebuchet? (y/n)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                Console.WriteLine("Awesome, let's get started...");
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("That's too bad. Maybe another time.");
            }
            else
            {
                Console.WriteLine("Input not recognized, please try again.");
            }
            int userInput = 0;
            Console.WriteLine("If you want to escape the loop, guess the number between 1 and 50.");
            while(userInput != 23)
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput < 23)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (userInput > 23)
                {
                    Console.WriteLine("Too high, try again.");
                }
            }
            Console.WriteLine("Congratulations, you've escaped the loop.");
        }
    }
}
