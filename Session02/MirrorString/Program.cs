using System;

namespace MirrorString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or sentence.");
            string input = Console.ReadLine();
            string reversion = "";
            for (int i = input.Length; i > 0; i--)
            {
                reversion = String.Concat(reversion, input.Substring(i-1, 1));
            }
            Console.WriteLine(reversion);
        }
    }
}
