using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerade med kommatecken.");
            var input = Console.ReadLine();

            var inputArray = input.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            foreach(var number in inputArray)
            {
                Console.WriteLine("Värdet är: " + number);
            }
        }
    }
}
