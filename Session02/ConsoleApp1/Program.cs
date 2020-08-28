using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;
            char answer = 'y';
                while (looping)
            { 
                Console.WriteLine("Please enter an amount of time in seconds.");
                int secondsInput = Convert.ToInt32(Console.ReadLine());
                int hours = secondsInput / 3600;
                int secondsRemaining = secondsInput % 3600;
                int minutes = secondsRemaining / 60;
                secondsRemaining = secondsRemaining % 60;
                Console.WriteLine(secondsInput + " seconds equals " + hours + " hours, " + minutes + " minutes and " + secondsRemaining + " seconds.");
                Console.WriteLine("Would you like to continue? (y/n)");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'n') { looping = false; }
            }
        }
    }
}